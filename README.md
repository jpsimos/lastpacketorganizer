# Last Packet Organizer

A Windows Forms desktop application for capturing, organizing, and analyzing CAN bus traffic in real time. It is designed to work with the [2018-Silverado-CAN](https://github.com/jpsimos/2018-Silverado-CAN) Teensy 4.0 dual-CAN gateway, which streams raw CAN frames as JSON lines over USB serial.

The tool is especially useful for reverse-engineering and filtering vehicle signals on the 2018 Chevrolet Silverado (and similar GM vehicles), where the Teensy listens to both the high-speed (500 kbps) and low-speed (33.333 kbps) CAN buses.

> **Why “Last Packet Organizer”?**  
> Because this is the *last* one. Seriously. After years of writing (and rewriting) CAN loggers, packet viewers, unique-set filters, and “just one more little GUI,” the author finally declared this the final iteration. No more. The name is both a promise and a threat. If you find a newer version, it is an impostor.

## Features

- **Serial logging** from a Teensy running the 2018-Silverado-CAN firmware
- **Two collection modes**:
  - **Linear List** (`.cll`) — keeps every frame in arrival order
  - **Unique Set** (`.cus`) — stores only distinct frames (based on ID, length, flags, and data bytes)
- Real-time DataGridView display with columns for timestamp, CAN ID, data payload, length, and bus number
- Optional **row updates** so the table continuously refreshes the latest value for each ID instead of only appending
- ID list sidebar for quick navigation
- **Set operations** on loaded data:
  - Intersect — keep only frames present in another file
  - Complement — remove frames that appear in another file
- Highlight matching cell values with a chosen color
- Save / open sessions as JSON line files
- Simple serial port selection and open/close controls

## Hardware & Companion Firmware

This application expects the serial protocol produced by the companion project:

**Repository:** [jpsimos/2018-Silverado-CAN](https://github.com/jpsimos/2018-Silverado-CAN)

- Teensy 4.0 (or compatible Teensy 3.x)
- Two CAN transceivers (e.g. TJA1050 or SN65HVD230)
- Connected to the vehicle’s high-speed and low-speed CAN buses

When logging is enabled the Teensy emits one JSON object per line at **115200 baud**:

```json
{"bus": 1, "id": 271646784, "len": 8, "r": 0, "e": 1, "o": 0, "data": [0, 42, 0, 0, 0, 0, 0, 0]}
```

Control commands sent by this application:

| Command | Effect              |
|---------|---------------------|
| `l11`   | Start logging both buses |
| `l00`   | Stop logging        |

(The Teensy also accepts `l10` / `l01` for single-bus logging.)

## File Formats

Saved files are plain text, one JSON object per line. The application adds a `"time"` field (DateTime.ToBinary()) when saving.

- `.cll` — CAN log linear list (all frames)
- `.cus` — CAN log unique set (deduplicated frames)

Example saved line:

```json
{"bus": 1, "id": 1234, "len": 8, "r": 0, "e": 0, "o": 0, "data": [0, 0, 0, 0, 0, 0, 0, 0], "time": 637000000000000000}
```

## Building

**Requirements**

- Visual Studio 2017 or later (or MSBuild)
- .NET Framework 4.7.2
- Windows (WinForms application)

**Steps**

1. Open `LastPacketOrganizer.sln`
2. Restore any missing references if prompted (System.Web.Extensions is required for JavaScriptSerializer)
3. Build in Debug or Release (x64 or AnyCPU)
4. The executable appears in `LastPacketOrganizer/bin/x64/Debug/` (or the corresponding configuration folder)

## Usage

1. Flash the Teensy with the 2018-Silverado-CAN firmware and connect it to the vehicle CAN buses and to the PC via USB.
2. Launch **Last Packet Organizer**.
3. In the Serial panel, select the Teensy’s COM port and click **Open**.
4. Choose collection mode:
   - **Linear List** — keep every frame
   - **Unique Set** — keep only unique frames
5. Optionally enable **Row Updates** for live refreshing of the table.
6. Click **Start**. The application sends `l11` and begins ingesting JSON frames.
7. Click **Stop** when finished (sends `l00`).
8. Use **File → Save** / **Save As** to write a `.cll` or `.cus` file.
9. Use **Tools → Filtering → Intersect** or **Complement** to compare against another saved file.
10. Use **Tools → Highlight Matching Cells** to color cells that share the same value.

## Project Structure

```
LastPacketOrganizer/
├── MainForm.cs / MainForm.Designer.cs   # Main window, serial worker, menu handlers
├── CANTable.cs / CANTable.Designer.cs   # DataGridView user control
├── CANMessage.cs                        # Frame model + JSON serialization
├── CANMessageContainer.cs               # Base collection + ID map
├── CANMessageList.cs                    # Linear list implementation
├── CANMessageHashSet.cs                 # Unique-set implementation
├── Utilities.cs                         # CRC32 and byte helpers
└── Program.cs                           # Entry point
```

## Notes & Limitations

- Unique-set equality ignores the timestamp and bus ID; it matches on ID, length, extended/remote/overrun flags, and the 8 data bytes.
- The application is Windows-only (WinForms + .NET Framework 4.7.2).
- Serial communication is line-oriented and assumes well-formed JSON from the Teensy.
- No built-in signal decoding — it is a raw frame organizer intended to be used alongside the Teensy’s own signal parsing or external tools.

## License

Copyright © 2020. See the repository for any additional licensing information.

## Related

- Companion firmware: [jpsimos/2018-Silverado-CAN](https://github.com/jpsimos/2018-Silverado-CAN)
- FlexCAN_T4 library (used by the Teensy firmware)

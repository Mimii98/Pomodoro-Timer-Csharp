# 🍅 Pomodoro Timer

Ein kleiner Pomodoro-Timer als Windows-Desktop-App, gebaut mit **C# und Windows Forms**. Hintergrundbild, Icon und die Buttons sind selbst gemalt.

## ✨ Features

- 25 Minuten Arbeitszeit, danach automatisch 5 Minuten Pause
- Sound-Signal beim Wechsel zwischen Arbeits- und Pausenphase
- Fenster bleibt immer im Vordergrund (Always-on-Top)
- Fenster stellt sich automatisch wieder her, falls es minimiert war, wenn die Pause endet
- Reset-Button, um den Timer jederzeit zurückzusetzen

## 🛠️ Verwendete Technik

- C# / .NET
- Windows Forms (WinForms)
- `System.Media.SoundPlayer` für die Sound-Effekte
- `System.Windows.Forms.Timer` für den Countdown

## 🧠 Wie der Code funktiert

Die gesamte Logik steckt in `Form1.cs`:

- **Start-Button** (`BtnStart_Click`): startet den WinForms-`Timer`, setzt `timeleft` auf 25 Minuten und `breaktime` auf 5 Minuten.
- **Timer-Tick** (`timer1_Tick`): läuft jede Sekunde und zieht eine Sekunde von `timeleft` ab. Ein `bool Isactive` merkt sich, ob gerade Arbeits- oder Pausenzeit läuft:
  - Ist die Arbeitszeit abgelaufen, schaltet `Isactive` auf `false`, `timeleft` wird auf die Pausenzeit gesetzt und ein Sound spielt ab.
  - Ist die Pausenzeit abgelaufen, schaltet `Isactive` zurück auf `true`, `timeleft` wird wieder auf 25 Minuten gesetzt, ein anderer Sound spielt ab, und falls das Fenster minimiert war, wird es automatisch wiederhergestellt.
- **Reset-Button** (`btnreset_Click`): stoppt den Timer und setzt die Anzeige zurück auf `00:00`.
- Die verbleibende Zeit wird als `TimeSpan` gespeichert und im Format `mm:ss` auf einem Label angezeigt.

## ▶️ Ausführen

1. `Promodoro timer/Promodoro timer.sln` in Visual Studio öffnen
2. Build & Start (F5)

## 🎨 Design

Hintergrund, Timer-Icon und Buttons sind selbst gemalt/gestaltet (siehe `WinFormsApp1/Resources/`).

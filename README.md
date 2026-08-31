Pomodoro Timer 

Ein kleiner Pomodoro Timer als Windows-Desktop-App, gebaut mit C# und Windows Forms. Hintergrundbild, Icon und die Buttons sind selbst gemalt. Aller erstes Projekt mit WinForms. 

Features 

Nach 25 Minuten Arbeitszeit springt der Timer automatisch auf die Pausenzeit und macht dabei einen Sound. Nach der Pausenzeit springt er wieder auf Arbeitszeit und macht ebenfalls wieder einen Sound. Jeweils beim Ablauf der Zeiten öffnet sich der Timer automatisch, falls minimiert. Falls nicht minimiert liegt das Timerfenster immer im Vordergrund und verschwindet nicht hinter Fenstern.  

Verwendete Technik 

Das Projekt basiert auf C# / .NET mit Windows Forms.. Für die Sound-Effekte kommt System.Media.SoundPlayer zum Einsatz, der Countdown läuft über System.Windows.Forms.Timer. 

Wie der Code funktioniert 

Die gesamte Logik steckt in Form1.cs. Der Start-Button (BtnStart_Click) startet den WinForms-Timer, setzt timeleft auf 25 Minuten und breaktime auf 5 Minuten. Der Timer-Tick (timer1_Tick) läuft jede Sekunde und zieht eine Sekunde von timeleft ab. Ein bool Isactive merkt sich, ob gerade Arbeits- oder Pausenzeit läuft: Ist die Arbeitszeit abgelaufen, schaltet Isactive auf false, timeleft wird auf die Pausenzeit gesetzt und ein Sound spielt ab. Ist die Pausenzeit abgelaufen, schaltet Isactive zurück auf true, timeleft wird wieder auf 25 Minuten gesetzt, und falls das Fenster minimiert war, wird es automatisch wieder hergestellt. Der Reset-Button (btnreset_Click) stoppt den Timer und setzt ihn auf 00:00. Die verbleibende Zeit wird als Format mm:ss auf einem Label angezeigt. 

Ausführen 

Die Datei `Pomodoro timer in Visual Studio öffnen und mit F5 builden und starten. 

Design 

Hintergrund, Timer-Icon und Buttons sind selbst gemalt/gestaltet (siehe WinFormsApp1/Resources/) 

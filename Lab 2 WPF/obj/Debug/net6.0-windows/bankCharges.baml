   M S B A M L   `   `   `  ????B  >Lab2WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lab2WPFLab2WPF  5   	       Lab2WPF.bankCharges   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Lab2WPF     5   	     ? Title$  bankCharges??5   	   $	??450??6   $	??800??6*   .??5	      ? .+?5
      ?? $!??Enter your current balance:??6
   $
??Left=?60   $??244,101,0,0q?6K   $	??Top=?6`   ?? 5      $<??6Enter the amount of cheques you've written this month:??6
   $
??Left=?6K   $??
92,147,0,0q?6f   $	??Top=?6z   ?? 5      $0??*The bank's service fees for the month are:??6
   $
??Left=?6?   $??166,248,0,0q?6Z   $	??Top=?6o   ?? 5      $ ??Amount of cheques written:??6
   $
??Left=?6/   $??239,297,0,0q?6J   $	??Top=?6_   ?? 5      $??Your ending balance is:??6
   $
??Left=?6,   $??264,349,0,0q?6G   $	??Top=?6\   ?? 5      -   5         ??Name$ currentBalanceBox??5      $
??Left=?6'   $??419,105,0,0q?6B    ?? TextWrapping$
 Wrap=?6W   $	??Top=?6k   $	??120??6?   ?? 5      -   5        $ amountChequesBox??5      $
??Left=?6&   $??419,151,0,0q?6A   $
 Wrap=?6V   $	??Top=?6j   $	??120??6?   ?? 5      -   5        $ serviceFeesBox??5      $
??Left=?6$   $??419,252,0,0q?6?   $
 Wrap=?6T   $	??Top=?6h   $	??120??6?   ?? 5      -   5        $ chequesBox2??5      $
??Left=?6!   $??419,301,0,0q?6<   $
 Wrap=?6Q   $	??Top=?6e   $	??120??6}   ?? 5      -   5        $ endBalanceBox??5      $
??Left=?6#   $??419,353,0,0q?6>   $
 Wrap=?6S   $	??Top=?6g   $	??120??6   ?? 5      -   5        $??	Calculate??5      $??Center=?6   $??Center=?6<   6W   ?? 5      -   5         ??Name$ title??5   
   $??BANK CHARGES??6   $??Center=?60   $??0,24,0,0q?6M   $	??Top=?6_   $??20(?6w   5      5      
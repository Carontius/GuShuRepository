   M S B A M L   `   `   `  ????R  NPiedra_Papel_Tijeras_00, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Piedra_Papel_Tijeras_00Piedra_Papel_Tijeras_00  5      &     Piedra_Papel_Tijeras_00.Registro   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Piedra_Papel_Tijeras_00     5        N? Title$  Registro??5	      .??5      ? ???	#FF2E2E2E ? RowDefinitions 5   
   ?? 5      ?? 5      $
??224* ?6   .+?5   
   ?? $??Piedra Papel Tijera??6   $
??Left=?6.   $??	326,8,0,0q?6I   $	??Top=?6\   $??46??6t   $	??178??6?   $??David CLM BoldItalic)?6?   $
??Bold"?6?   $??20(?6?   $??Normal$?6?   ???	#FFC5B9B9$??1??6?   ?? 5   
   $
??Left=?6   $??61??6+   $??
311,54,0,0q?67   $	??Top=?6K   $	??218??6c   $$??/download-removebg-preview.png??6o   $??1??6?    J? OpacityMask 5      ?? 5       ?? ImageSource$$ /download-removebg-preview.png??6   5      ?? 5   
   $??Registration :??6   $
??Left=?6)   $??347,154,0,0q?6D   $	??Top=?6Y   $??43??6q   $	??121??6}   ???	#FFDCD1D1$??14(?6?   $
??Bold"?6?   $??1??6?   ?? 5   
   -   5         ??Name$ UserNameBlock??5      $
??Left=?6+   $??131,201,0,0q?6F   $
??Wrap=?6[   $
??User??6o   $	??Top=?6{   $??21??6?   $??46??6?   ???	#FFFBFAFB$
??Bold"?6?   $??14(?6?   $??	KacstBook)?6?   $??1??6?   ?? 5   
   -   5        $ UserPassBlock??5      $
??Left=?6+   $??131,238,0,0q?6F   $
??Wrap=?6[   $
??Pass??6o   $	??Top=?6{   $??23??6?   $??46??6?   ???	#FFF5F2F5$??	KacstBook)?6?   $??14(?6?   $
??Bold"?6?   $??1??6?   ?? 5   
   -   5         ??Name$ RegisterBtn??5      $
??Send??6&   $
??Left=?65   $??326,321,0,0q?6P   $	??Top=?6e   $??22??6}   $	??143??6?   ???	#FF4A4646 ? Cursor$ Arrow??6?    J? Opacity$	 0.5Q?6?   $
??Bold"?6?   $??1??6?   6?   ?? 5   
   -   5        $ FName??5      $
??Left=?6#   $??398,202,0,0q?6>   $
??Wrap=?6S   $??
First Name??6g   $	??Top=?6y   $??21??6?   $??87??6?   ???	#FFFBFAFB$
??Bold"?6?   $??14(?6?   $??	KacstBook)?6?   $??1??6?   ?? 5   
   -   5        $ LName??5      $
??Left=?6#   $??398,239,0,0q?6>   $
??Wrap=?6S   $??	Last Name??6g   $	??Top=?6x   $??21??6?   $??71??6?   ???	#FFFBFAFB$
??Bold"?6?   $??14(?6?   $??	KacstBook)?6?   $??1??6?   ?? 5   
   -   5        $
 Mail??5      $
??Left=?6"   $??131,272,0,0q?6=   $
??Wrap=?6R   $??Email??6f   $	??Top=?6s   $??21??6?   $??46??6?   ???	#FFFBFAFB$
??Bold"?6?   $??14(?6?   $??	KacstBook)?6?   $??1??6?   ?? 5   
   -   5        $ 	BckButtom??5      $
??Back??6$   $
??Left=?63   $??	10,15,0,0q?6N   $	??Top=?6a   $??19??6y   $??42??6?   ???	#FF4A4646$ Arrow??6?   $	 0.5Q?6?   $
??Bold"?6?    J? RenderTransformOrigin$ 0.626,-0.476&?6?   $??1??6  ?? 5   
   -   5        	 ??Name$	 emailbox??5      $
??Left=?6$   $??22??6?   $??182,272,0,0q?6K   
 ?? TextWrapping$

 Wrap=?6`   $?? ??6t   $	??Top=?6|   $	??182??6?   ???	#FF2E2E2E???	#FF757474???	#FFA29E9E$??1??6?   ?? 5   
   -	   5        $	 fnamebox??5      $
??Left=?6$   $??22??6?   $??485,202,0,0q?6K   $

 Wrap=?6`   $?? ??6t   $	??Top=?6|   $	??182??6?   ???	#FF2E2E2E???	#FF757474???	#FFA29E9E$??1??6?   ?? 5    
   -
   5        $	 lnamebox??5       $
??Left=?6$   $??22??6?   $??485,239,0,0q?6K   $

 Wrap=?6`   $?? ??6t   $	??Top=?6|   $	??182??6?   ???	#FF2E2E2E???	#FF757474???	#FFA29E9E$??1??6?   ?? 5!   
   -   5        $	 userbox??5!      $
??Left=?6#   $??22??6>   $??182,202,0,0q?6J   $

 Wrap=?6_   $?? ??6s   $	??Top=?6{   $	??182??6?   ???	#FF2E2E2E???	#FFA29E9E???	#FF757474$??1??6?   ?? 5"   
   -   5        $	 passbox??5"      $
??Left=?6#   $??22??6>   $??182,238,0,0q?6J   $

 Wrap=?6_   $?? ??6s   $	??Top=?6{   $	??182??6?   ???	#FF2E2E2E???	#FF757474???	#FFA29E9E$??1??6?   5$      5%      
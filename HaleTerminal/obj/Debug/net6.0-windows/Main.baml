   M S B A M L   `   `   `  ????G  CHaleTerminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HaleTerminalHaleTerminal  5   	       HaleTerminal.Main   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:HaleTerminal     5   	   -   5          ? Title$  Hale Terminal??5   	   $	??600??6   $
??1000??6,   ???	#FF141414 ? WindowStartupLocation$ CenterScreen=?6P   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      .+?5   
   ?? $
??CANC??6   $
??Left=?6    $	??Top=?6;   $??5,5,0,0q?6S   
???  ??$??0q?6u   $??50??6?   $??25??6?   
???   ?$
??Bold"?6?   ?? 5   
   $
??MENU??6   $
??Left=?6    $	??Top=?6;   $??60,5,0,0q?6S   ???	#FF27F627$??0q?6|   $??50??6?   $??25??6?   
???   ?$
??Bold"?6?   ?? 5   
   -   5         ??Name$ CommandTextbox??5      ???	#FF141414
???????$
??Left=?6m   $	??Top=?6?   $??5,40,0,0q?6?   $	??500??6?   $??18(?6?   
???????$??26??6?    ?? 
CaretBrush
 ????  ?? CharacterCasing$ Upper=?6  ?? 5   
   $??5,42,490,515q?6   .+?5      ?? -   5         ??Name$ Caret??5      $y?	Collapsed=?5       ?? Left$ 0??5      
 ?? Top$ 0??5      $??7??5      $??20??5      ???	#FF4EA7D2	 ? Triggers	 5      :? 5      
 :? RoutedEvent$
 Border.Loaded??6#   .[?5      ?? .??5      ?? -   5         ??Name$ CaretStoryBoard??5   )    g? RepeatBehavior$ Forever??6B   .??5   "   ??  ?? TargetProperty$ Background.Color?6?    g? Duration$ 0:0:0:1D?6l    g? FillBehavior$ HoldEnd=?6   g?5   *   p?  ?? KeyTime$ 	0:0:0.000??6@    ?? Value$ 	#FF4EA7D2??6T   5!   #   5"      5#      5$      5&      5'       ? 5)   
   -   5          ?Name$ 	MainFrame??5)      $??0,75,0,0q?6#     ? NavigationUIVisibility$ Hidden=?65   5+      5,      5-      
   M S B A M L   `   `   `  ����D  @TikTakToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TikTakToe.ControlsTikTakToe.Controls  5          TikTakToe.GameView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      T PMahApps.Metro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5      0	controls1 clr-namespace:TikTakToe.Controls  5      $	��800��5      $	��500��5      .��5      � 
�������  � ColumnDefinitions  5	   
   �� 5
      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��.2* �6   .+�5   
   �� $��0��6   $	��100��5      $	��100��5      $��Images\TikTak.png��5      �� 5   
   -   5         ��Name$ 	TurnLabel��5      $��0��6#   $��1��5      $��3��5      $
��Left=�5       $��Center=�5!      $��Turno: ��5"      $	��300��5#      $��Segoe UI Light)�5$      $��25(�5%      %   TikTakToe.Controls.SpaceControl  5&   
   -   5          Name$ SpaceControl1��5&   !   %   TikTakToe.Controls.SpaceControl   SpaceClicked$! SpaceControl_OnSpaceClicked��5+   !   $��1��5'   !   $��1��5(   !   $	��150��5)   !   $	��130��5*   !   5+   !   �� 5,   
   $��1��6   $��3��5-      $��1��5.      $��2��5/      $��Right=�50      
����� �51        52   
   -   5        $ SpaceControl4��52   !   $! SpaceControl_OnSpaceClicked��57   !   $��1��53   !   $��2��54   !   $	��150��55   !   $	��130��56   !   57   !   �� 58   
   $��1��6   $��3��59      $��2��5:      $��2��5;      $��Right=�5<      
����� �5=        5>   
   -   5        $ SpaceControl7��5>   !   $! SpaceControl_OnSpaceClicked��5C   !   $��1��5?   !   $��3��5@   !   $	��150��5A   !   $	��130��5B   !   5C   !     5D   
   -   5        $ SpaceControl2��5D   !   $! SpaceControl_OnSpaceClicked��5I   !   $��2��5E   !   $��1��5F   !   $	��150��5G   !   $	��130��5H   !   5I   !   �� 5J   
   $��2��6   $��1��5K      $��3��5L      $��2��5M      $	��Top=�5N      
����� �5O        5P   
   -   5        $ SpaceControl5��5P   !   $! SpaceControl_OnSpaceClicked��5U   !   $��2��5Q   !   $��2��5R   !   $	��150��5S   !   $	��130��5T   !   5U   !     5V   
   -   5        $ SpaceControl8��5V   !   $! SpaceControl_OnSpaceClicked��5[   !   $��2��5W   !   $��3��5X   !   $	��150��5Y   !   $	��130��5Z   !   5[   !     5\   
   -   5        $ SpaceControl3��5\   !   $! SpaceControl_OnSpaceClicked��5a   !   $��3��5]   !   $��1��5^   !   $	��150��5_   !   $	��130��5`   !   5a   !   �� 5b   
   $��3��6   $��1��5c      $��3��5d      $��2��5e      $	��Top=�5f      
����� �5g        5h   
   -	   5        $ SpaceControl6��5h   !   $! SpaceControl_OnSpaceClicked��5m   !   $��3��5i   !   $��2��5j   !   $	��150��5k   !   $	��130��5l   !   5m   !     5n   
   -
   5        $ SpaceControl9��5n   !   $! SpaceControl_OnSpaceClicked��5s   !   $��3��5o   !   $��3��5p   !   $	��150��5q   !   $	��130��5r   !   5s   !   5t      5u      
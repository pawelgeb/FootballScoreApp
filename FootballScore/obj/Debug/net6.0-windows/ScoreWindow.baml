   M S B A M L   `   `   `  ����K  GFootballScoreWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FootballScoreWPFFootballScoreWPF  5   	   "    FootballScoreWPF.ScoreWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FootballScoreWPF     5   	     � Title$  ScoreWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��33* �6   �� 5      $
��130* �6   �� 5      $
��637* �6   .+�5   
   �� -   5        $��HomeName��5      $
��Left=�6"   $��
30,126,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6�   $	��213��6�   $��35��6�   $��3��6  ��6e   ��  �� Path$  footballStats.HomeTeamName�6  �� 5   
   -   5        $��Score��5      $
��Left=�6   $��118,126,0,0q�6:   $
 Wrap=�6O   $	��Top=�6�   $	��213��6�   $��35��6�   $��2��6�   ��6c   �� $  footballStats.HomeTeamName�6�   �� 5   
   -   5        $��AwayName��5      $
��Left=�6#   $��395,126,0,0q�6>   $
 Wrap=�6S   $	��Top=�6�   $	��213��6�   $��35��6�   $��2��6�   ��6g   �� $  footballStats.HomeTeamName�6�   �� 5   
   -   5        $��StadiumName��5      $
��Left=�6&   $��	395,0,0,0q�6A   $
 Wrap=�6T   $��Center=�6�   $	��213��6�   $��35��6�   $��2��6�   ��6h   �� $  footballStats.HomeTeamName�6�   �� 5   
   -   5        $��Publish��5      $
��Left=�6#   $��395,282,0,0q�6>   $	��Top=�6S   $��33��6k   $	��213��6w   $��2��6�   5      5      
   M S B A M L   `   `   `  ����>  :SFS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SFSSFS  5   	       SFS.Add_Player   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:SFS     5   	     � Title$  
Add_Player��5   	   $	��400��6   $	��500��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ new.png��6   .+�5   
   �� -   5         ��Name$ Number��5      $
��Left=�6"   $��32��6=    �� TextWrapping$
 Wrap=�6I   $	��Top=�6]   $	��136��6u   $��216,149,0,0q�6�   $��16(�6�   $��Traditional Arabic)�6�   �� 5   
   -   5        $ 	team_name��5      $
��Left=�6%   $��32��6@   $
 Wrap=�6L   $	��Top=�6`   $	��136��6x   $��216,224,0,0q�6�   $��16(�6�   $��Traditional Arabic)�6�   	� 5   
   -   5        $	��yes��5   /    	� 	GroupName$ Medical Form��6   $�� ��6:   $
��Left=�6E   $	��Top=�6`   $��198,129,0,0q�6x   6�   	� 5   
   -   5        $��no��5   /   $ Medical Form��6   $�� ��69   $
��Left=�6D   $	��Top=�6_   $��293,131,0,0q�6w   	� 5   
   -   5        $
��male��5   )   $ Gender��6   $�� ��65   $
��Left=�6@   $	��Top=�6[   $��
293,89,0,0q�6s   	� 5   
   -   5        $��female��5   )   $ Gender��6   $�� ��67   $
��Left=�6B   $	��Top=�6]   $��
198,88,0,0q�6u    J� RenderTransformOrigin$ 7.021,0.125&�6�   �� 5   
   -   5         ��Name$ button��5      $��405,329,0,1.333q�6!   $��0,0,0,1q�6O   $
��Left=�6i   $��75��6�   $
��Auto��6�   ��5      �� 5      ��5      �� 5      $ Add.png��6    j� TileMode$
 Tile=�63   5      �� 5   
   -   5        $
 back��5      $�� ��6   $
��Left=�6*   $	��Top=�6E   $��73��6]   $��40��6h   $��0q�6t    �� 	ClickMode$ Press=�6�   $��
12,329,0,0q�6�   ��5      �� 5      ��5      �� 5       $ back.png��6   5"      �� 5#   
   -	   5        	 ��Name$	 label2_Copy10��5#      $��Player Name:��6'   $
��Left=�6>   $	��Top=�6Y   $��	12,39,0,0q�6q   $��Traditional Arabic)�6�   $��22(�6�   $
��Bold"�6�   �� 5$   
   -
   5        $	 label2_Copy2��5$      $��Gender:��6&   $
��Left=�68   $	��Top=�6S   $��	11,75,0,0q�6k   $��Traditional Arabic)�6~   $��22(�6�   $
��Bold"�6�   �� 5%   
   -   5        $	 label2_Copy4��5%      $��F��6&   $
��Left=�62   $	��Top=�6M   $��
229,75,0,0q�6e   $��Traditional Arabic)�6y   $��22(�6�   $
��Bold"�6�   �� 5&   
   -   5        $	 label2_Copy3��5&      $��M��6&   $
��Left=�62   $	��Top=�6M   $��
321,80,0,0q�6e   $��Traditional Arabic)�6y   $��22(�6�   $
��Bold"�6�   �� 5'   
   -   5        $	 label2_Copy��5'      $��Medical Form:��6%   $
��Left=�6=   $	��Top=�6X   $��
12,113,0,0q�6p   $��Traditional Arabic)�6�   $��22(�6�   $
��Bold"�6�   $	��154��6�   �� 5(   
   -   5        $	 label2_Copy6��5(      $	��Yes��6&   $
��Left=�64   $	��Top=�6O   $��229,118,0,0q�6g   $��Traditional Arabic)�6|   $��22(�6�   $
��Bold"�6�   �� 5)   
   -   5        $	 label2_Copy7��5)      $��No��6&   $
��Left=�63   $	��Top=�6N   $��321,118,0,0q�6f   $��Traditional Arabic)�6{   $��22(�6�   $
��Bold"�6�   �� 5*   
   -   5        $	 label2_Copy11��5*      $��Mobile Number:��6'   $
��Left=�6@   $	��Top=�6[   $��
12,149,0,0q�6s   $��Traditional Arabic)�6�   $��22(�6�   $
��Bold"�6�   �� 5+   
   -   5        $	 label2_Copy12��5+      $��Date of birth :��6'   $
��Left=�6A   $	��Top=�6\   $��
12,185,0,0q�6t   $��Traditional Arabic)�6�   $��22(�6�   $
��Bold"�6�   �� 5,   
   -   5        $	 label2_Copy13��5,      $��Team Name :��6'   $
��Left=�6=   $	��Top=�6X   $��
12,224,0,0q�6p   $��Traditional Arabic)�6�   $��22(�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5-   
   -   5        
  Name$

 Date��5-      $
��Left=�6#   $	��Top=�6>   $��217,193,0,0q�6V   $	��135��6k   $��26��6w   �� 5.   
   -   5        $ coach��5.      $
��Left=�6!   $��32��6<   $
 Wrap=�6H   $	��Top=�6\   $	��136��6t   $��216,265,0,0q�6�   $��16(�6�   $��Traditional Arabic)�6�   �� 5/   
   -   5        $	 label2_Copy1��5/      $��Coach Name :��6&   $
��Left=�6=   $	��Top=�6X   $��
12,265,0,0q�6p   $��Traditional Arabic)�6�   $��22(�6�   $
��Bold"�6�   $	��155��6�   �� 50   
   -   5        $ player_name��50      $
��Left=�6'   $��32��6B   $
 Wrap=�6N   $	��Top=�6b   $	��136��6z   $��
216,34,0,0q�6�   $��16(�6�   $��Traditional Arabic)�6�   �� 51   
   -   5        $ button1��51      $�� ��6"   $
��Left=�6-   $��30��6H   $
��Auto��6S   $��0q�6a   $��0,0,0,344.333q�6u   ��52      �� 53      $ 
wrongg.png��6   55      57      58      
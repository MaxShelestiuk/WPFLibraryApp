   M S B A M L   `   `   `  ����E  AWpfLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfLibrary.ViewsWpfLibrary.Views  5   	   !    WpfLibrary.Views.AdminPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfLibrary.Views     5   	     � Title$  
AdminPanel��5   	   $	��450��6   $	��800��6)   .��5	      � $��
0,0,-0.4,0q�6   .+�5
   
   �� $;��5pack://application:,,,/Content/Backgrounds/images.jpg��6   $
��Fill=�6O   �� 5   
   $��Center=�6   $��334,43,337,0q�61   $��Admin panel��6H   $	��Top=�6[   $��18(�6s   $	��123��6�   � 5   
   $��27,117,576,22q�6   .+�5      � $��0,0,0,93q�6   .+�5      �� -   5         ��Name$ ButtonUsersMenu��5      $��
Users Menu��6V   $
��Left=�6k   $	��Top=�6�   $	��176��6�   $��39��6�   ��62   �� *UserMenuCommand+6�   �� 5      -   5        $ ButtonBookMenu��5      $��
Books Menu��6U   $��Center=�6l   $��39��6�   $
��Left=�6�   $	��176��6�   ��61   �� *BookMenuCommand+6�   �� 5      -   5        $ ButtonAuthorMenu��5      $��Author Menu��6Y   $��Bottom=�6p   $��39��6�   $
��Left=�6�   $	��176��6�   ��63   �� *AuthorMenuCommand+6�   5      �� 5      -   5        $ 
ButtonBack��5      $
��Back��6I   $
��Left=�6X   $	��114��6t   $��34��6�   $��Bottom=�6�   $��0,0,0,10q�6�   ��6)   �� *BackCommand+6�   5      � 5   
   $��534,118,28,96q�6   .+�5      �� -   5        $ ButtonConAutBook��5      $��Connect Authors to Books��6W   $��Right=�6z   $	��222��6�   $��38��6�   $��Center=�6�   ��6/   �� *ConnAuthBookCommand+6�   �� 5      -   5        $ ButtonToCabinet��5      $��To Main page��6M   $	��Top=�6e   $��38��6}   $��Right=�6�   $	��176��6�   ��6.   �� *
ToMainPage+6�   �� 5      -   5        $ ButtonOrders��5      $��Orders��6L   $��Bottom=�6]   $��39��6x   $��Right=�6�   $	��176��6�   ��6+   �� *OrderCommand+6�   5      5      5      
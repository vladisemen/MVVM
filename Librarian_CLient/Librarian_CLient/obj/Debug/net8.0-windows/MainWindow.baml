   M S B A M L   `   `   `  ����K  GLibrarian_CLient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Librarian_CLientLibrarian_CLient  5   	   !    Librarian_CLient.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Librarian_CLient     5   	     � Title$  	Libririan��5   	   $	��450��6   $	��800��6(   .��5	      � -   5         �Name$ Grid1��5	       � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Жанр��6   $��0��6   $��0��6,   $��10q�6<   �� 5   
   $��0��6)   $��1��66   $��10q�6F   ��6   �� *Genre+6F   �� 5   
   $��
Автор��6   $��1��6    $��0��6-   $��10q�6=   �� 5   
   $��1��6*   $��1��67   $��10q�6G   ��6   �� *Author+6G   �� 5   
   $��Год издания��6   $��2��6&   $��0��63   $��10q�6C   �� 5   
   $��2��6(   $��1��65   $��10q�6E   ��6   �� *Year+6E   �� 5   
   $!��Получить книгу��6   $��3��6*   $��1��67   $��Center=�6G   $��10q�6d   $	��100��6p   $��30��6|   ��6�   �� *HttpSenderCommand+5      5       
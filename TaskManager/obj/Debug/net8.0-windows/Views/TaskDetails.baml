   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BankApplicationBankApplication  5   	   !    BankApplication.TaskDetails   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BankApplication     5   	     � Title$  TaskDetails��5   	   $	��450��6   $	��800��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $�� ��6   $��Center=�6   $
��Bold"�6<   $��20(�6N   �� 5      $��1��6   $��Title:��6!   �� 5      -   5         ��Name$ title��5   %   $��1��6   $��	100,0,0,0q�64   ��6G   �� *
task.Title+�� 5      $��2��6   $��Description:��6!   �� 5      -   5        $
 desc��5   %   $��2��6   $��	100,0,0,0q�63   ��6F   �� *task.Description+5      � 5   
   $��1��6   $��0,20,0,0q�6    5      �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5$      �� $��0��6   $��User:��6!   �� 5%      -   5         ��Name$ users��5%   |   $��1��6    �� SelectedItem 6#   �� *selectedUsername+ �� Mode$ TwoWay=���6Z   �� *	usernames+5'      5(      �� 5)   
   $��2��6   $
��Save��6   $��Center=�6S   $��0,163,0,-78q�6p   $	��166��6�   
���   �
���������6-   �� *AssignUserCommand+ � 	Resources 5*       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5+      " ��6   .�5,      ��  �@��CornerRadius$	 5��65   5-      5.      5/      �� 50   
   $��Task Details��6   $��Center=�6'   $
��Bold"�6D   $��20(�6V   $��Bahnschrift Light)�6d   $��0,0,0,55q�6�   �� 51   
   $��1��6   $��0,31,0,0q�6   
���   �$	��Top=�6@   
���   �6X   �� 52   
   $��1��6   $��	0,121,0,0q�6   
���   �$	��Top=�6A   
���   �$��2��6f   53      54      
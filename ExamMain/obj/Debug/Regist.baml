   M S B A M L   `   `   `  ����C  ?ExamMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ExamMainExamMain  5   	       ExamMain.Regist   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ExamMain     5   	     � Title$  Registration��5   	   $	��475��6   $	��500��6+    � WindowStartupLocation$ CenterScreen=�67    � Icon$ icons\reg.png��6\   .��5	      �� ���	#FFE0E2C6.+�5
   
   ��  �� TextAlignment$ Center=�6   $��Registretion��6+   ���	#FF120B97$��28(�6V   $��	0,10,0,10q�6d   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5      �� $ Center=�6   $��
Fullname: ��6/   $��30��6A   ���	#FF0DA156$��24(�6d   $	��150��6r   �� 5      -   5        $��txtBoxFullName��5   7   $��30��6M   ���	#FF0DA156$��22(�6p   $	��250��6~   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5      �� $ Center=�6   $��Email: ��6/   $��30��6>   ���	#FF0DA156$��24(�6a   $	��150��6o   �� 5      -   5        $��txtBoxAddress��5   4   $��30��6I   ���	#FF0DA156$��22(�6l   $	��250��6z   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5      �� $ Center=�6   $��Date of birth: ��6/   $��30��6F   ���	#FF0DA156$��24(�6i   $	��150��6w   (  "System.Windows.Controls.DatePicker  5      -   5        $��dpBirth��5   =   $��30��6L   ���	#FF0DA156$��18(�6o   $	��250��6}   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5      �� $ Center=�6   $��Phone: ��6/   $��30��6>   ���	#FF0DA156$��24(�6a   $	��150��6o   �� 5      -   5        $��	txtNumber��5      $��30��6F   ���	#FF0DA156$��22(�6i   $	��250��6w   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5      �� -   5         ��Name$ checker��5      $��Admin��6(   $��30��68   ���	#FF0DA156$��24(�6[   $	��150��6i   6�   5      �� 5   
   -   5         ��Name$ 	stackHide��5      $ 
Horizontal=�6(   $��Center=�6A   $��5q�6^   $y�Hidden=�6i   .+�5      �� $ Center=�6   $��Admin Pass: ��6/   $��30��6C   ���	#FF0DA156$��24(�6f   $	��150��6t   �� 5       -   5        $��txtAdminPass��5       $��30��6F   ���	#FF0DA156$��22(�6i   $	��250��6w   5!      �� 5"   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5#      �� $ Center=�6   $��
Password: ��6/   $��30��6A   ���	#FF0DA156$��24(�6d   $	��150��6r   G� 5$      -   5        $��txtBoxPassword��5$   ?   $��30��6U   ���	#FF0DA156$��22(�6x   $	��250��6�   5%      �� 5&   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5'      �� $ Center=�6   $��Secret Word: ��6/   $��30��6D   ���	#FF0DA156$��24(�6g   $	��150��6u   �� 5(      -	   5        $��txtBoxSecret��5(   5   $��30��6I   ���	#FF0DA156$��22(�6l   $	��250��6z   5)      �� 5*   
   $ 
Horizontal=�6   $��Center=�6.   $��5q�6K   .+�5+      �� -
   5        $��btnRegister��5+   '   {�.  $��Register��6K   ���	#FF0DA156$��24(�6u   $	��150��6�   $��10q�6�   ���	#FFFFD4D46�   �� 5,      -   5        $��	btnCancel��5,      $��Cancel��65   ���	#FF0DA156$��24(�6]   $	��150��6k   $��10q�6w   ���	#FFFFD4D46�   5-      5.      5/      
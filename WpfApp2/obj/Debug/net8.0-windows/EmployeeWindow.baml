   M S B A M L   `   `   `  ����  WpfApp2    WpfApp2.EmployeeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$#  Окно сотрудника��5   	   $	��450��6!   $	��800��6.   .��5      � .+�5   
   �� 
����·�$��20(�6*   .@�5      �� $��
Заказ��6   
�������.��5	      �� 
����·�.��5
      �� $��10q�6!   .+�5      �� $<��6Выберите сезон и ассортимент:��6$   $
��Bold"�6I   $��22(�6[   �� 5      -   5         ��Name$ SeasonComboBox��5   #   $��0,0,0,10q�6;   .@�5      �� $��Лето��6+   �� 5      $��Зима��6+   �� 5      $��
Осень��6+   �� 5      $��
Весна��6+   5      �� 5      -   5        $ AssortmentComboBox��5   #   $��0,0,0,10q�6?   .@�5      �� $ ��Обувь для лета��6+   �� 5      $ ��Обувь для зимы��6+   �� 5      $"��Обувь для осени��6+   �� 5      $"��Обувь для весны��6+   5      �� 5      -   5        $��Сделать заказ��5   !   
��� � �$��10q�6f   �� 5      -   5        $+��%Сменить ползователя��5   !   
�������$��10q�6l   5      5      5      �� 5      $!��Обратная связь��6   
�������.��5      �� 
����·�.��5       �� $��10q�6!   .+�5!      �� $<��6Обратная связь для магазинов:��6$   $
��Bold"�6I   $��22(�6[   �� 5"      -   5        $ FeedbackTypeComboBox��5"   #   $��0,0,0,10q�6A   .@�5#      �� $��Пожелания��6+   �� 5$      $��Претензии��6+   �� 5%      $*��$Брак на ассортимент��6+   5&      �� 5'      -   5         ��Name$ FeedbackMessageTextBox��5'   "   $��0,0,0,10q�6B   $��80��6T    �� AcceptsReturn$
 True��6`    �� TextWrapping$
 Wrap=�6u   �� 5(      -   5        $��Отправить��5(   !   
��� � �$��10q�6i   �� 5)      -   5         ��Name$ FeedbackImage��5)       $	��200��67   $	��200��6D   $��0,10,0,0q�6P   �� 5*      -	   5        $/��)Загрузить изображение��5*   !   $��10q�6a   5+      5,      5-      �� 5/      $��Статус заявки��6   
�������.��50      �� 
����·�.��51      �� $��10q�6!   .+�52      �� $ ��Статус заявки:��6$   $
��Bold"�6:   $��22(�6L   �� 53      -
   5         ��Name$ OrderStatusListBox��53   "   $	��200��6>   $��0,5,0,10q�6K   .@�54      �� $��Принято��6*   �� 55      $��В процессе��6*   �� 56      $��Отправлено��6*   57      �� 58      -   5        $#��Обновить статус��58   !   
��� � �$��10q�6t   59      5:      5;      5<      5=      5>      
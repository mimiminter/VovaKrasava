using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mukha_otrezki_praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отрезки и данные удалены");
            Canvas.Children.RemoveRange(2, Canvas.Children.Count - 2); A_deleniye.Clear();
            x1_1.Clear(); x2_1.Clear(); x_povorot.Clear(); ugol_2.Clear(); B_deleniye.Clear();
            y1_1.Clear(); y2_1.Clear(); y_povorot.Clear(); C_deleniye.Clear();
            x1_2.Clear(); x2_2.Clear(); ugol_povorot.Clear(); D_deleniye.Clear();
            y1_2.Clear(); y2_2.Clear(); ugol_1.Clear();

        }

        private void Button_Add_1(object sender, RoutedEventArgs e)
        {
            if (x1_1.Text == "" || y1_1.Text == "" || x1_2.Text == "" || y1_2.Text == "")
            {
                MessageBox.Show("Все ячейки должны быть заполнены");
            }
            else
            {
                try
                {
                    MessageBox.Show("Отрезок создан");
                    double x1 = Convert.ToDouble(x1_1.Text) * 10;
                    double y1 = Convert.ToDouble(y1_1.Text) * 10;
                    double x2 = Convert.ToDouble(x1_2.Text) * 10;
                    double y2 = Convert.ToDouble(y1_2.Text) * 10;

                    double x11 = Convert.ToDouble(x1_1.Text);
                    double y11 = Convert.ToDouble(y1_1.Text);
                    double x22 = Convert.ToDouble(x1_2.Text);
                    double y22 = Convert.ToDouble(y1_2.Text);



                    Line line = new Line
                    {
                        X1 = x1 + 250,
                        Y1 = -y1 + 200,
                        X2 = x2 + 250,
                        Y2 = -y2 + 200,
                        Stroke = Brushes.Gray,
                        StrokeThickness = 2,
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Center
                    };
                    Canvas.Children.Add(line);


                }
                catch
                {
                    MessageBox.Show("Введите цифры");
                }
            }


        }
        private void Button_Add_2(object sender, RoutedEventArgs e)
        {
            if (x2_1.Text == "" || y2_1.Text == "" || x2_2.Text == "" || y2_2.Text == "")
            {
                MessageBox.Show("Все ячейки должны быть заполнены");
            }
            else
            {
                try
                {
                    MessageBox.Show("Отрезок создан");
                    double x1 = Convert.ToDouble(x2_1.Text) * 10;
                    double y1 = Convert.ToDouble(y2_1.Text) * 10;
                    double x2 = Convert.ToDouble(x2_2.Text) * 10;
                    double y2 = Convert.ToDouble(y2_2.Text) * 10;

                    double x11 = Convert.ToDouble(x2_1.Text);
                    double y11 = Convert.ToDouble(y2_1.Text);
                    double x22 = Convert.ToDouble(x2_2.Text);
                    double y22 = Convert.ToDouble(y2_2.Text);



                    Line line1 = new Line
                    {
                        X1 = x1 + 250,
                        Y1 = -y1 + 200,
                        X2 = x2 + 250,
                        Y2 = -y2 + 200,
                        Stroke = System.Windows.Media.Brushes.Violet,
                        StrokeThickness = 2,
                        HorizontalAlignment = HorizontalAlignment.Left,
                        VerticalAlignment = VerticalAlignment.Center
                    };
                    Canvas.Children.Add(line1);


                }
                catch
                {
                    MessageBox.Show("Введите цифры");
                }
            }
        }

        private void Button_Click_Ugol(object sender, RoutedEventArgs e)
        {
            try
            {
                double x1 = Convert.ToDouble(x1_1.Text) * 10;
                double y1 = Convert.ToDouble(y1_1.Text) * 10;
                double x2 = Convert.ToDouble(x1_2.Text) * 10;
                double y2 = Convert.ToDouble(y1_2.Text) * 10;

                double x3 = Convert.ToDouble(x2_1.Text) * 10;
                double y3 = Convert.ToDouble(y2_1.Text) * 10;
                double x4 = Convert.ToDouble(x2_2.Text) * 10;
                double y4 = Convert.ToDouble(y2_2.Text) * 10;


                double ugol = Math.Atan2(y2 - y1, x2 - x1);
                ugol = (ugol * 180) / Math.PI;
                double outugol1 = Math.Round(ugol, 2);
                ugol_1.Text = Convert.ToString(outugol1 + "°");


                double ugol1 = Math.Atan2(y4 - y3, x4 - x3);
                ugol1 = (ugol1 * 180) / Math.PI;
                double outugol2 = Math.Round(ugol1, 2);
                ugol_2.Text = Convert.ToString(outugol2 + "°");


            }
            catch
            {
                MessageBox.Show("Ошибка, на экране только 1 отрезок или ни одного");
            }
        }

        private void Button_Click_Peresecheniye(object sender, RoutedEventArgs e)
        {
            if (x1_1.Text == "" || x1_2.Text == "" || x2_1.Text == "" || x2_2.Text == "" || y1_1.Text == "" || y1_2.Text == "" || y2_1.Text == "" || y2_2.Text == "")
            {
                MessageBox.Show("Введите данные для проверки пересечения");
            }
            else
            {
                try
                {
                    double x1 = Convert.ToDouble(x1_1.Text) * 10;
                    double x2 = Convert.ToDouble(x1_2.Text) * 10;
                    double x3 = Convert.ToDouble(x2_1.Text) * 10;
                    double x4 = Convert.ToDouble(x2_2.Text) * 10;

                    double y1 = Convert.ToDouble(y1_1.Text) * 10;
                    double y2 = Convert.ToDouble(y1_2.Text) * 10;
                    double y3 = Convert.ToDouble(y2_1.Text) * 10;
                    double y4 = Convert.ToDouble(y2_2.Text) * 10;

                    double Ua, Ub, numerator_a, numerator_b, denominator;

                    denominator = (y4 - y3) * (x1 - x2) - (x4 - x3) * (y1 - y2);

                    if (denominator == 0)
                    {
                        if ((x1 * y2 - x2 * y1) * (x4 - x3) - (x3 * y4 - x4 * y3) * (x2 - x1) == 0 && (x1 * y2 - x2 * y1) * (y4 - y3) - (x3 * y4 - x4 * y3) * (y2 - y1) == 0)
                        {
                            MessageBox.Show("Отрезки пересекаются");
                        }
                        else
                        {
                            MessageBox.Show("Не пересекаются");
                        }
                    }
                    else
                    {
                        numerator_a = (x4 - x2) * (y4 - y3) - (x4 - x3) * (y4 - y2);
                        numerator_b = (x1 - x2) * (y4 - y2) - (x4 - x2) * (y1 - y2);
                        Ua = numerator_a / denominator;
                        Ub = numerator_b / denominator;
                        if (Ua >= 0 && Ua <= 1 && Ub >= 0 && Ub <= 1) MessageBox.Show("Отрезки пересекаются");
                        else MessageBox.Show("Не пересекаются");
                    }
                }
                catch
                {
                    MessageBox.Show("Данные некорректны");
                }
            }

        }
        private void Button_Click_Tochka_Peresecheniya(object sender, RoutedEventArgs e)
        {
            if (x1_1.Text == "" || x1_2.Text == "" || x2_1.Text == "" || x2_2.Text == "" || y1_1.Text == "" || y1_2.Text == "" || y2_1.Text == "" || y2_2.Text == "")
            {
                MessageBox.Show("Введите данные для проверки пересечения");
            }
            else
            {
                try
                {
                    double x1 = Convert.ToDouble(x1_1.Text) * 10;
                    double y1 = Convert.ToDouble(y1_1.Text) * 10;
                    double x2 = Convert.ToDouble(x1_2.Text) * 10;
                    double y2 = Convert.ToDouble(y1_2.Text) * 10;

                    double x3 = Convert.ToDouble(x2_1.Text) * 10;
                    double y3 = Convert.ToDouble(y2_1.Text) * 10;
                    double x4 = Convert.ToDouble(x2_2.Text) * 10;
                    double y4 = Convert.ToDouble(y1_2.Text) * 10;

                    double Ua, Ub, numerator_a, numerator_b, denominator;

                    denominator = (y4 - y3) * (x1 - x2) - (x4 - x3) * (y1 - y2);
                    numerator_a = (x4 - x2) * (y4 - y3) - (x4 - x3) * (y4 - y2);
                    numerator_b = (x1 - x2) * (y4 - y2) - (x4 - x2) * (y1 - y2);
                    Ua = numerator_a / denominator;
                    Ub = numerator_b / denominator;

                    x1 /= 10;
                    x2 /= 10;
                    x3 /= 10;
                    x4 /= 10;

                    y1 /= 10;
                    y2 /= 10;
                    y3 /= 10;
                    y4 /= 10;

                    double x = 0;
                    double y = 0;
                    if (Ua >= 0 && Ua <= 1 && Ub >= 0 && Ub <= 1)
                    {
                        if (x1 <= x2 && x3 <= x4)
                        {
                            if (x1 >= x2)
                            {
                                x1 = x1 + x2 - (x2 = x1);
                                y1 = y1 + y2 - (y2 = y1);
                            }
                            if (x3 >= x4)
                            {
                                x3 = x3 + x4 - (x4 = x3);
                                y3 = y3 + y4 - (y4 = y3);
                            }

                            if (y2 == y1)
                            {
                                double k1 = 0;

                                if (y3 == y4)
                                {
                                    double k2 = (y4 - y3) / (x4 - x3);

                                    if (k1 == k2)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        double b1 = y1 - k1 * x1;
                                        double b2 = y3 - k2 * x3;

                                        x = (b2 - b1) / (k1 - k2);
                                        y = k1 * x + b1;


                                    }
                                }
                            }
                            else
                            {
                                double k1 = (y2 - y1) / (x2 - x1);
                                if (y3 == y4)
                                {
                                    double k2 = 0;


                                    if (k1 == k2)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        double b1 = y1 - k1 * x1;
                                        double b2 = y3 - k2 * x3;

                                        x = (b2 - b1) / (k1 - k2);
                                        y = k1 * x + b1;
                                    }
                                }
                                else
                                {
                                    double k2 = (y4 - y3) / (x4 - x3);

                                    if (k1 == k2)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        double b1 = y1 - k1 * x1;
                                        double b2 = y3 - k2 * x3;


                                        x = (b2 - b1) / (k1 - k2);
                                        y = k1 * x + b1;



                                    }
                                }
                            }
                        }
                        else
                        {
                            if (y2 == y1)
                            {
                                double k1 = 0;

                                if (y3 == y4)
                                {
                                    double k2 = (y4 - y3) / (x4 - x3);

                                    if (k1 == k2)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        double b1 = y1 - k1 * x1;
                                        double b2 = y3 - k2 * x3;

                                        x = (b2 - b1) / (k1 - k2);
                                        y = k1 * x + b1;


                                    }
                                }
                            }
                            else
                            {
                                double k1 = (y2 - y1) / (x2 - x1);
                                if (y3 == y4)
                                {
                                    double k2 = 0;

                                    if (k1 == k2)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        double b1 = y1 - k1 * x1;
                                        double b2 = y3 - k2 * x3;

                                        x = (b2 - b1) / (k1 - k2);
                                        y = k1 * x + b1;
                                    }
                                }
                                else
                                {
                                    double k2 = (y4 - y3) / (x4 - x3);

                                    if (k1 == k2)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        double b1 = y1 - k1 * x1;
                                        double b2 = y3 - k2 * x3;


                                        x = (b2 - b1) / (k1 - k2);
                                        y = k1 * x + b1;



                                    }
                                }
                            }
                        }
                        double outputX = Math.Round(x, 2);
                        double outputY = Math.Round(y, 2);
                        MessageBox.Show("Отрезки пересекаются в точке " + outputX + ";" + outputY);
                    }
                    else
                    {
                        MessageBox.Show("Отрезки не пересекаются");
                    }
                }
                catch
                {
                    MessageBox.Show("Данные некорректны");
                }
            }
        }

        private void Button_Click_Povorot(object sender, RoutedEventArgs e)
        {
            if (x1_1.Text == "" || x1_2.Text == "" || y1_1.Text == "" || y1_2.Text == "")
            {
                MessageBox.Show("Введите данные 1 отрезка для поворота");
            }
            else
            {
                try
                {
                    double x1 = Convert.ToDouble(x1_1.Text) * 10;
                    double y1 = Convert.ToDouble(y1_1.Text) * 10;
                    double x2 = Convert.ToDouble(x1_2.Text) * 10;
                    double y2 = Convert.ToDouble(y1_2.Text) * 10;

                    double TurnX = Convert.ToDouble(x_povorot.Text);
                    double TurnY = Convert.ToDouble(y_povorot.Text);

                    double TurnAngle = Convert.ToDouble(ugol_povorot.Text);

                    Point pointTurn = new Point(TurnX, TurnY);
                    Point pointx1 = new Point(x1, y1);
                    Point pointx2 = new Point(x2, y2);

                    Point p_newA = new Point();
                    Point p_newB = new Point();
                    double rad = (Math.PI / 180) * TurnAngle;

                    p_newA.X = pointTurn.X + (pointx1.X - pointTurn.X) * Math.Cos(rad) - (pointx1.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
                    p_newA.Y = pointTurn.Y + (pointx1.X - pointTurn.X) * Math.Sin(rad) + (pointx1.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

                    p_newB.X = pointTurn.X + (pointx2.X - pointTurn.X) * Math.Cos(rad) - (pointx2.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
                    p_newB.Y = pointTurn.Y + (pointx2.X - pointTurn.X) * Math.Sin(rad) + (pointx2.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

                    Line MyLine = new Line();
                    MyLine.X1 = p_newA.X + 250;
                    MyLine.Y1 = -p_newA.Y + 200;
                    MyLine.X2 = p_newB.X + 250;
                    MyLine.Y2 = -p_newB.Y + 200;
                    MyLine.Stroke = System.Windows.Media.Brushes.Gray;
                    MyLine.StrokeThickness = 2;
                    MyLine.HorizontalAlignment = HorizontalAlignment.Left;
                    MyLine.VerticalAlignment = VerticalAlignment.Center;
                    Canvas.Children.Add(MyLine);

                    p_newA.X /= 10;
                    p_newA.Y /= 10;
                    p_newB.X /= 10;
                    p_newB.Y /= 10;

                    double outputpnewAX = Math.Round(p_newA.X, 2);
                    double outputpnewAY = Math.Round(p_newA.Y, 2);
                    double outputpnewBX = Math.Round(p_newB.X, 2);
                    double outputpnewBY = Math.Round(p_newB.Y, 2);

                    x1_1.Text = Convert.ToString(outputpnewAX);
                    y1_1.Text = Convert.ToString(outputpnewAY);
                    x1_2.Text = Convert.ToString(outputpnewBX);
                    y1_2.Text = Convert.ToString(outputpnewBY);
                }
                catch
                {
                    MessageBox.Show("Данные некорректны");
                }
            }
        }

        private void Button_Click_Razdelit(object sender, RoutedEventArgs e)
        {
            if (x1_1.Text == "" || x1_2.Text == "" || y1_1.Text == "" || y1_2.Text == "")
            {
                MessageBox.Show("Введите данные 1 отрезка для выполнения деления");
            }
            else
            {
                try
                {
                    double x1 = Convert.ToDouble(x1_1.Text) * 10;
                    double y1 = Convert.ToDouble(y1_1.Text) * 10;
                    double x2 = Convert.ToDouble(x1_2.Text) * 10;
                    double y2 = Convert.ToDouble(y1_2.Text) * 10;

                    double A = Convert.ToDouble(A_deleniye.Text);
                    double B = Convert.ToDouble(B_deleniye.Text);
                    double C = Convert.ToDouble(C_deleniye.Text);
                    double D = Convert.ToDouble(D_deleniye.Text);

                    double P1 = A / B;
                    double P2 = P1 / C;
                    double P3 = P2 / D;

                    double X_1 = (x1 + P1 * x2) / (1 + P1);
                    double outX_1 = Math.Round(X_1, 2);
                    double Y_1 = (y1 + P1 * y2) / (1 + P1);
                    double outY_1 = Math.Round(Y_1, 2);

                    double X_2 = (x1 + P2 * x2) / (1 + P2);
                    double outX_2 = Math.Round(X_2, 2);
                    double Y_2 = (y1 + P2 * y2) / (1 + P2);
                    double outY_2 = Math.Round(Y_2, 2);

                    double X_3 = (x1 + P3 * x2) / (1 + P3);
                    double outX_3 = Math.Round(X_3, 2);
                    double Y_3 = (y1 + P3 * y2) / (1 + P3);
                    double outY_3 = Math.Round(Y_3, 2);

                    Ellipse elipse = new Ellipse();
                    elipse.Width = 4;
                    elipse.Height = 4;
                    elipse.StrokeThickness = 5;
                    elipse.Stroke = Brushes.White;
                    elipse.Fill = Brushes.White;
                    elipse.Margin = new Thickness(248 + outX_1, 198 - outY_1, 0, 0);
                    Canvas.Children.Add(elipse);

                    Ellipse elipse1 = new Ellipse();
                    elipse1.Width = 4;
                    elipse1.Height = 4;
                    elipse1.StrokeThickness = 5;
                    elipse1.Stroke = Brushes.White;
                    elipse1.Fill = Brushes.White;
                    elipse1.Margin = new Thickness(248 + outX_2, 198 - outY_2, 0, 0);
                    Canvas.Children.Add(elipse1);

                    Ellipse elipse2 = new Ellipse();
                    elipse2.Width = 4;
                    elipse2.Height = 4;
                    elipse2.StrokeThickness = 5;
                    elipse2.Stroke = Brushes.White;
                    elipse2.Fill = Brushes.White;
                    elipse2.Margin = new Thickness(248 + outX_3, 198 - outY_3, 0, 0);
                    Canvas.Children.Add(elipse2);
                }
                catch
                {
                    MessageBox.Show("Данные некорректны");
                }
            }
        }
        ///ТЕСТИРОВАНИЕ///
        /////////////////
        public bool TestPeresechenie(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double x = 0;
            double y = 0;
            if (x1 <= x2 && x3 <= x4)
            {
                if (x1 >= x2)
                {
                    x1 = x1 + x2 - (x2 = x1);
                    y1 = y1 + y2 - (y2 = y1);
                }
                if (x3 >= x4)
                {
                    x3 = x3 + x4 - (x4 = x3);
                    y3 = y3 + y4 - (y4 = y3);
                }

                if (y2 == y1)
                {
                    double k1 = 0;

                    if (y3 == y4)
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                            return true;
                        }
                    }
                }
                else
                {
                    double k1 = (y2 - y1) / (x2 - x1);
                    if (y3 == y4)
                    {
                        double k2 = 0;


                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;
                            MessageBox.Show(x.ToString() + " " + y.ToString());
                            return true;
                        }
                    }
                    else
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;


                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                            return true;

                        }
                    }
                }
            }
            else
            {
                if (y2 == y1)
                {
                    double k1 = 0;

                    if (y3 == y4)
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                        }
                    }
                }
                else
                {
                    double k1 = (y2 - y1) / (x2 - x1);
                    if (y3 == y4)
                    {
                        double k2 = 0;

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;

                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;
                        }
                    }
                    else
                    {
                        double k2 = (y4 - y3) / (x4 - x3);

                        if (k1 == k2)
                        {

                        }
                        else
                        {
                            double b1 = y1 - k1 * x1;
                            double b2 = y3 - k2 * x3;


                            x = (b2 - b1) / (k1 - k2);
                            y = k1 * x + b1;

                            MessageBox.Show(x.ToString() + " " + y.ToString());
                        }
                    }
                }
            }
            MessageBox.Show(x.ToString() + " " + y.ToString());
            return true;
        }



        public bool TestUgol(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            try
            {
                double radians1 = Math.Atan2(y2 - y1, x2 - x1);
                radians1 = (radians1 * 180) / Math.PI;
                double outputradians1 = Math.Round(radians1, 2);

                MessageBox.Show("угол отрезка 1: " + outputradians1.ToString() + "°");

                double radians2 = Math.Atan2(y4 - y3, x4 - x3);
                radians2 = (radians2 * 180) / Math.PI;
                double outputradians2 = Math.Round(radians2, 2);

                MessageBox.Show("угол отрезка 2: " + outputradians2.ToString() + "°");

                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool TestPovorot(double x1, double y1, double x2, double y2, double TurnX, double TurnY, double TurnAngle)
        {
            Point pointTurn = new Point(TurnX, TurnY);
            Point pointx1 = new Point(x1, y1);
            Point pointx2 = new Point(x2, y2);

            Point p_newA = new Point();
            Point p_newB = new Point();
            double rad = (Math.PI / 180) * TurnAngle;

            p_newA.X = pointTurn.X + (pointx1.X - pointTurn.X) * Math.Cos(rad) - (pointx1.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
            p_newA.Y = pointTurn.Y + (pointx1.X - pointTurn.X) * Math.Sin(rad) + (pointx1.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

            p_newB.X = pointTurn.X + (pointx2.X - pointTurn.X) * Math.Cos(rad) - (pointx2.Y - pointTurn.Y) * Math.Sin(rad) + pointTurn.X;
            p_newB.Y = pointTurn.Y + (pointx2.X - pointTurn.X) * Math.Sin(rad) + (pointx2.Y - pointTurn.Y) * Math.Cos(rad) + pointTurn.Y;

            p_newA.X /= 10;
            p_newA.Y /= 10;
            p_newB.X /= 10;
            p_newB.Y /= 10;

            MessageBox.Show("новая кооридината A x1 " + p_newA.X.ToString() + " новая кооридината A y1 " + p_newA.Y.ToString());
            MessageBox.Show("новая кооридината B x1 " + p_newB.X.ToString() + " новая кооридината B y1 " + p_newB.Y.ToString());

            return true;
        }

        public bool TestRazdelit(double x1, double y1, double x2, double y2, double A, double B, double C, double D)
        {
            double P1 = A / B;
            double P2 = P1 / C;
            double P3 = P2 / D;

            double X_1 = (x1 + P1 * x2) / (1 + P1);
            double outX_1 = Math.Round(X_1, 2);
            double Y_1 = (y1 + P1 * y2) / (1 + P1);
            double outY_1 = Math.Round(Y_1, 2);

            double X_2 = (x1 + P2 * x2) / (1 + P2);
            double outX_2 = Math.Round(X_2, 2);
            double Y_2 = (y1 + P2 * y2) / (1 + P2);
            double outY_2 = Math.Round(Y_2, 2);

            double X_3 = (x1 + P3 * x2) / (1 + P3);
            double outX_3 = Math.Round(X_3, 2);
            double Y_3 = (y1 + P3 * y2) / (1 + P3);
            double outY_3 = Math.Round(Y_3, 2);

            MessageBox.Show("точка отношения 1 " + outX_1 + "/" + outY_1);
            MessageBox.Show("точка отношения 2 " + outX_2 + "/" + outY_2);
            MessageBox.Show("точка отношения 3 " + outX_3 + "/" + outY_3);

            return true;
        }

        public bool Vivod(double x1, double y1, double x2, double y2)
        {
            MessageBox.Show("Отрезок создан");
            x1 = Convert.ToDouble(x1) * 10;
            y1 = Convert.ToDouble(y1) * 10;
            x2 = Convert.ToDouble(x1) * 10;
            y2 = Convert.ToDouble(y1) * 10;
            Line line = new Line
            {
                X1 = x1 + 250,
                Y1 = -y1 + 200,
                X2 = x2 + 250,
                Y2 = -y2 + 200,
                Stroke = Brushes.Gray,
                StrokeThickness = 2,
                HorizontalAlignment = HorizontalAlignment.Left,
                VerticalAlignment = VerticalAlignment.Center
            };
            return true;



        }




    }
}

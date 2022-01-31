using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsecutiveOnes
{
    public class TabuAlgorithm
    {
        private int number_of_restarts;
        private int size_of_tabu_list;
        private int acceptable_iterations_no_improvement;
        private int amount_diversify_movements;
        private Matrix problem_instance;
        private int final_cmax;
        private float final_time;
        


        public TabuAlgorithm(int no_restarts, int tabu_list_size, int max_no_improvement_iterations,int diversify_movements, Matrix problem_matrix)
        {
            number_of_restarts = no_restarts;
            size_of_tabu_list = tabu_list_size;
            acceptable_iterations_no_improvement = max_no_improvement_iterations;
            amount_diversify_movements = diversify_movements;
            problem_instance = problem_matrix;
            
        }
        //columns x rows _ % _ errors _ #
        public void testy_bledow() // testy bledow
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i = 0; i <= 80; i += 10) //% bledow
            {
                Debug.WriteLine($"bledy: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j = 0; j < 10; j++) // instancje
                {
                    Debug.WriteLine($"instance: {j}");
                    string plik_do_odczytu = $"50x50_60_{i}_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/" + plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = 50;
                    size_of_tabu_list = 20;
                    acceptable_iterations_no_improvement = 250;
                    amount_diversify_movements = 100;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }

            Debug.WriteLine($"%jedynek avg_cmax avg_time");
            for (int i = 0; i < instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{(i)*10} {avg_cmax} {avg_time}");
            }
        }
        public void testy_jedynek()
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i = 30; i <= 90; i += 10) //% jedynek
            {
                Debug.WriteLine($"jedynki: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j = 0; j < 10; j++) // instancje
                {
                    Debug.WriteLine($"instance: {j}");
                    string plik_do_odczytu = $"50x50_{i}_20_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/" + plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = 50;
                    size_of_tabu_list = 20;
                    acceptable_iterations_no_improvement = 250;
                    amount_diversify_movements = 100;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }

            Debug.WriteLine($"%jedynek avg_cmax avg_time");
            for (int i = 0; i < instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{i} {avg_cmax} {avg_time}");
            }
        }
        public void testy_parametru_tabusize()
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i = 5; i <= 40; i += 5) //tabu size
            {
                Debug.WriteLine($"diversify: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j = 0; j < 10; j++) // instancje
                {
                    Debug.WriteLine($"instance: {j}");
                    string plik_do_odczytu = $"40x40_80_0_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/" + plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = 50;
                    size_of_tabu_list = i;
                    acceptable_iterations_no_improvement = 250;
                    amount_diversify_movements = 100;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }

            Debug.WriteLine($"tabu avg_cmax avg_time");
            for (int i = 0; i < instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{(i+1)*5} {avg_cmax} {avg_time}");
            }
        }
        public void testy_parametru_diverse()
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i = 10; i <= 100; i += 10) //diversify movements
            {
                Debug.WriteLine($"diversify: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j = 0; j < 10; j++) // instancje
                {
                    Debug.WriteLine($"instance: {j}");
                    string plik_do_odczytu = $"40x40_80_0_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/" + plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = 50;
                    size_of_tabu_list = 15;
                    acceptable_iterations_no_improvement = 250;
                    amount_diversify_movements = i;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }

            Debug.WriteLine($"diversify avg_cmax avg_time");
            for (int i = 0; i < instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{i} {avg_cmax} {avg_time}");
            }
        }
        public void testy_parametru_iterations()
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i = 50; i <= 500; i += 50) //iteracje
            {
                Debug.WriteLine($"iterations: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j = 0; j < 10; j++) // instancje
                {
                    Debug.WriteLine($"instance: {j}");
                    string plik_do_odczytu = $"40x40_80_0_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/" + plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = 50;
                    size_of_tabu_list = 15;
                    acceptable_iterations_no_improvement = i;
                    amount_diversify_movements = 15;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }

            Debug.WriteLine($"iterations avg_cmax avg_time");
            for (int i = 0; i < instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{(i + 1) * 25} {avg_cmax} {avg_time}");
            }
        }
        public void testy_parametru_restarts()
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i=10; i<=100; i += 10) //restarty
            {
                Debug.WriteLine($"restarts: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j = 0; j < 10; j++) // instancje
                {
                    Debug.WriteLine($"instance: {j}");
                    string plik_do_odczytu = $"40x40_80_0_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/" + plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = i;
                    size_of_tabu_list = 15;
                    acceptable_iterations_no_improvement = 50;
                    amount_diversify_movements = 15;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }

            Debug.WriteLine($"restarts avg_cmax avg_time");
            for (int i = 0; i < instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{(i + 1) * 10} {avg_cmax} {avg_time}");
            }
        }
        public void testy_rozmiaru()
        {
            List<List<float>> instance_times = new List<List<float>>();
            List<List<float>> instance_cmaxes = new List<List<float>>();
            for (int i = 10; i <= 70; i += 10) //rozmiary
            {
                Debug.WriteLine($"i: {i}");
                List<float> single_times = new List<float>();
                List<float> single_cmaxes = new List<float>();
                for (int j=0; j < 10; j++) //instancje
                {
                    Debug.WriteLine($"j: {j}");
                    string plik_do_odczytu = $"{i}x{i}_70_60_{j}.txt";
                    string macierz = File.ReadAllText("C:/Users/wszym/Desktop/testin_zp/"+plik_do_odczytu);
                    problem_instance = new Matrix(macierz);
                    number_of_restarts = 50;
                    size_of_tabu_list = 15;
                    acceptable_iterations_no_improvement = 200;
                    amount_diversify_movements = 50;
                    this.StartTabus();
                    single_times.Add(this.get__final_time());
                    single_cmaxes.Add(this.get_final_cmax());
                }
                instance_times.Add(single_times);
                instance_cmaxes.Add(single_cmaxes);
            }
            Debug.WriteLine("finished!!!");
            Debug.WriteLine($"size avg_cmax avg_time");
            for (int i=0; i<instance_times.Count; i++)
            {
                float avg_cmax = Queryable.Average(instance_cmaxes[i].AsQueryable());
                float avg_time = Queryable.Average(instance_times[i].AsQueryable());
                Debug.WriteLine($"{(i+1)*10} {avg_cmax} {avg_time}");
            }
            
        }

        public float get__final_time()
        {
            return final_time;
        }

        public int get_final_cmax()
        {
            return final_cmax;
        }

        public string StartTabus()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int restart_count = 0;

            var rand = new Random();
            Matrix best_global_arrangement = new Matrix(problem_instance);

            try
            {
                while (restart_count < number_of_restarts)
                {
                    
                    Matrix best_local_arrangement = new Matrix(problem_instance);
                    Queue<(int, int)> tabu_list = new Queue<(int, int)>();
                    int no_improvement_iterations_count = 0;
                    while (no_improvement_iterations_count < acceptable_iterations_no_improvement)
                    {
                        int first_column = -1;
                        int second_column = -1;
                        Matrix new_arrangement = new Matrix(best_local_arrangement);
                        do
                        {
                            first_column = rand.Next(0, problem_instance.Get_no_columns());
                            do
                            {
                                second_column = rand.Next(0, problem_instance.Get_no_columns());
                            } while (second_column == first_column);

                            if (tabu_list.Contains((first_column, second_column)) || tabu_list.Contains((second_column, first_column)))
                            {
                                Matrix new_arrangement_aspiration = new Matrix(best_local_arrangement);
                                new_arrangement_aspiration.Switch_columns(first_column, second_column);
                                new_arrangement_aspiration.Calculate_cmax(new_arrangement_aspiration.Get_matrix());
                                if (new_arrangement_aspiration.Get_cmax() < best_local_arrangement.Get_cmax())
                                {
                                    best_local_arrangement = new Matrix(new_arrangement_aspiration);
                                }
                            }
                        } while (tabu_list.Contains((first_column, second_column)) || tabu_list.Contains((second_column, first_column)));


                        new_arrangement.Switch_columns(first_column, second_column);
                        new_arrangement.Calculate_cmax(new_arrangement.Get_matrix());

                        if (new_arrangement.Get_cmax() < best_local_arrangement.Get_cmax())
                        {

                            best_local_arrangement = new Matrix(new_arrangement);
                            if (tabu_list.Count == size_of_tabu_list)
                            {
                                tabu_list.Dequeue();
                            }
                            tabu_list.Enqueue((first_column, second_column));
                            no_improvement_iterations_count = 0;
                            //Debug.WriteLine(best_local_arrangement.Debug_columns_to_string());
                        }
                        else if (new_arrangement.Get_cmax() == best_local_arrangement.Get_cmax() && no_improvement_iterations_count > acceptable_iterations_no_improvement - amount_diversify_movements) //todo: zmienic 70 na jakis procent ruchow bez poprawy
                        {
                            best_local_arrangement = new Matrix(new_arrangement);
                            if (tabu_list.Count == size_of_tabu_list)
                            {
                                tabu_list.Dequeue();
                            }
                            tabu_list.Enqueue((first_column, second_column));
                            no_improvement_iterations_count++;
                            //Debug.WriteLine(best_local_arrangement.Debug_columns_to_string());
                        }
                        else
                        {
                            no_improvement_iterations_count++;
                        }
                        //Debug.WriteLine(no_improvement_iterations_count);
                    }
                    

                    if (best_local_arrangement.Get_cmax() < best_global_arrangement.Get_cmax())
                    {
                        best_global_arrangement = new Matrix(best_local_arrangement);
                        restart_count++;
                    }
                    else
                    {
                        restart_count++;
                    }
                    

                }
            }
            catch (OperationCanceledException ex)
            {

            }

            watch.Stop();
            
            best_global_arrangement.Calculate_cmax(best_global_arrangement.Get_matrix());


            this.final_cmax = best_global_arrangement.Get_cmax();
            this.final_time = watch.ElapsedMilliseconds / 1000;
            string result = "";
            return result;
        }
        public string StartTabu(IProgress<int> progress, System.Threading.CancellationToken token)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int restart_count = 0;
            
            var rand = new Random();
            Matrix best_global_arrangement = new Matrix(problem_instance);
            
            try
            {
                while (restart_count < number_of_restarts)
                {
                    token.ThrowIfCancellationRequested();
                    progress.Report(restart_count);
                    Matrix best_local_arrangement = new Matrix(problem_instance);
                    Queue<(int, int)> tabu_list = new Queue<(int, int)>();
                    int no_improvement_iterations_count = 0;
                    while (no_improvement_iterations_count < acceptable_iterations_no_improvement)
                    {
                        int first_column = -1;
                        int second_column = -1;
                        Matrix new_arrangement = new Matrix(best_local_arrangement);
                        do
                        {
                            first_column = rand.Next(0, problem_instance.Get_no_columns());
                            do
                            {
                                second_column = rand.Next(0, problem_instance.Get_no_columns());
                            } while (second_column == first_column);

                            if (tabu_list.Contains((first_column, second_column)) || tabu_list.Contains((second_column, first_column)))
                            {
                                Matrix new_arrangement_aspiration = new Matrix(best_local_arrangement);
                                new_arrangement_aspiration.Switch_columns(first_column, second_column);
                                new_arrangement_aspiration.Calculate_cmax(new_arrangement_aspiration.Get_matrix());
                                if (new_arrangement_aspiration.Get_cmax() < best_local_arrangement.Get_cmax())
                                {
                                    best_local_arrangement = new Matrix(new_arrangement_aspiration);
                                }
                            }
                        } while (tabu_list.Contains((first_column, second_column)) || tabu_list.Contains((second_column, first_column)));


                        new_arrangement.Switch_columns(first_column, second_column);
                        new_arrangement.Calculate_cmax(new_arrangement.Get_matrix());

                        if (new_arrangement.Get_cmax() < best_local_arrangement.Get_cmax())
                        {

                            best_local_arrangement = new Matrix(new_arrangement);
                            if (tabu_list.Count == size_of_tabu_list)
                            {
                                tabu_list.Dequeue();
                            }
                            tabu_list.Enqueue((first_column, second_column));
                            no_improvement_iterations_count = 0;
                            Debug.WriteLine(best_local_arrangement.Debug_columns_to_string());
                        }
                        else if (new_arrangement.Get_cmax() == best_local_arrangement.Get_cmax() && no_improvement_iterations_count > acceptable_iterations_no_improvement - amount_diversify_movements) //todo: zmienic 70 na jakis procent ruchow bez poprawy
                        {
                            best_local_arrangement = new Matrix(new_arrangement);
                            if (tabu_list.Count == size_of_tabu_list)
                            {
                                tabu_list.Dequeue();
                            }
                            tabu_list.Enqueue((first_column, second_column));
                            no_improvement_iterations_count++;
                            Debug.WriteLine(best_local_arrangement.Debug_columns_to_string());
                        }
                        else
                        {
                            no_improvement_iterations_count++;
                        }
                        //Debug.WriteLine(no_improvement_iterations_count);
                    }

                    if (best_local_arrangement.Get_cmax() < best_global_arrangement.Get_cmax())
                    {
                        best_global_arrangement = new Matrix(best_local_arrangement);
                        restart_count++;
                    }
                    else
                    {
                        restart_count++;
                    }
                    Debug.WriteLine("#################");
                    Debug.WriteLine(restart_count);
                    Debug.WriteLine("#################");
                }
            }
            catch (OperationCanceledException ex)
            {
                
            }

            watch.Stop();
            progress.Report(restart_count);
            Debug.WriteLine(problem_instance.Debug_to_string());
            Debug.WriteLine(problem_instance.Get_cmax());
            Debug.WriteLine("---------------------------------------");
            Debug.WriteLine(best_global_arrangement.Debug_to_string());
            Debug.WriteLine(best_global_arrangement.Get_cmax());
            best_global_arrangement.Calculate_cmax(best_global_arrangement.Get_matrix());
            Debug.WriteLine(best_global_arrangement.Debug_columns_to_string());
            Debug.WriteLine(best_global_arrangement.Get_final_columns());

            this.final_cmax = problem_instance.Get_cmax();
            this.final_time = watch.ElapsedMilliseconds / 1000;
            string result ="";
            result += $"Matrix size: {problem_instance.Get_no_rows()} x {problem_instance.Get_no_columns()} " + Environment.NewLine;
            result += $"Initial colum arrangement cmax: {problem_instance.Get_cmax()}" + Environment.NewLine;
            result += @$"Applied tabu search parameters: 
    Restarts: {number_of_restarts}
    Tabu list size: {size_of_tabu_list}
    Iterations with no improvement: {acceptable_iterations_no_improvement}
    Diversify iterations: {amount_diversify_movements}" + Environment.NewLine;
            result += $"Cmax of best solution found: {best_global_arrangement.Get_cmax()}" + Environment.NewLine;
            result += $"New arrangement: {best_global_arrangement.Debug_columns_to_string()}" + Environment.NewLine;
            result += $"Arrangement with columns removed: {best_global_arrangement.Get_final_columns()}" + Environment.NewLine;
            return result;
        }

         
             
       
            

        public int Get_number_of_restarts()
        {
            return number_of_restarts;
        }

        public string DebugToString()
        {
            return problem_instance.Debug_to_string();
        }
    }
}

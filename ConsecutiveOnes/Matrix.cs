using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;

namespace ConsecutiveOnes
{
    public class Matrix
    {
        private int columns;
        private int rows;
        private int ones_percentage;
        private int errors;
        private int[,] matrix2d;
        private int cmax;
        private int[] columns_ids;
        private int[] columns_left;
        private int cmax_estimation;

        public Matrix(int columns_size, int rows_size, int sequence_percentage, int no_errors)
        {
            columns = columns_size;
            rows = rows_size;
            matrix2d = new int[rows, columns];
            columns_ids = Enumerable.Range(0, columns).ToArray();
            ones_percentage = sequence_percentage;
            errors = no_errors;
            //cmax = 0;
            this.Initialize_matrix();
            this.Input_errors_into_matrix();
            cmax_estimation = this.Calculate_cmax(matrix2d);
            this.Randomize_columns_in_matrix();
            cmax = this.Calculate_cmax(matrix2d);

        }

        public Matrix(string data)
        {
            string[] lines = data.Split('\n','\r');
            //string[] elements = lines[0].Split(' ');
            List<List<int>> contents_matrix = new List<List<int>>();
            int columns_count = 0;
            int rows_count = 0;

            
            foreach(string line in lines)
            {
                List<int> contents_line = new List<int>();
                if(line == "")
                {
                    continue;
                }
                string[] elements = line.Split(' ');
                foreach(string element in elements)
                {
                    if(element == "")
                    {
                        continue;
                    }
                    contents_line.Add(Convert.ToInt32(element));
                }
                contents_matrix.Add(contents_line);
            }

            for(int i=1; i< contents_matrix.Count; i++)
            {
                if(contents_matrix[i-1].Count != contents_matrix[i].Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            rows_count = contents_matrix.Count;
            columns_count = contents_matrix[0].Count;
            

            rows = rows_count;
            columns = columns_count;
            matrix2d = new int[rows, columns];
            columns_ids = Enumerable.Range(0, columns).ToArray();
            ones_percentage = -1;
            errors = -1;

            for (int i=0; i< rows_count; i++)
            {
                for(int j = 0; j<columns_count; j++)
                {
                    matrix2d[i,j] = contents_matrix[i][j];
                }
            }
            cmax = this.Calculate_cmax(matrix2d);


        }

        

        public Matrix(Matrix to_clone)
        {
            this.columns = to_clone.columns;
            this.rows = to_clone.rows;
            this.matrix2d = to_clone.matrix2d.Clone() as int[,];
            this.columns_ids = to_clone.columns_ids.Clone() as int[];
            this.ones_percentage = to_clone.ones_percentage;
            this.errors = to_clone.errors;
            this.cmax = to_clone.cmax;
        }

        public void Initialize_matrix()
        {
            Array.Clear(matrix2d, 0, matrix2d.Length);
            for (int i = 0; i < rows; i++)
            {
                int length_of_ones = matrix2d.GetLength(1) * ones_percentage / 100;
                Random rnd = new Random();
                int starting_position_of_ones = rnd.Next(0, ((matrix2d.GetLength(1) - length_of_ones)+1));

                for (int j = starting_position_of_ones; j < (starting_position_of_ones + length_of_ones); j++)
                {
                    matrix2d[i, j] = 1;
                }
            }


        }
        public void Input_errors_into_matrix()
        {
            var rand = new Random();
            int[,] matrix2d_copy = new int[rows, columns];
            matrix2d_copy = matrix2d.Clone() as int[,];
            List<int> selected_columns = new List<int>();
            var error_cord_list = new List<(int, int)>();
            int column_id;
            int row_id;
            for (int i = 0; i < errors; i++)
            {
                column_id = rand.Next(1, columns - 1);
                if (!selected_columns.Contains(column_id))
                {
                    selected_columns.Add(column_id);
                    cmax++;
                }
                /*do
                {
                    column_id = rand.Next(1, columns - 1);
                } while (selected_columns.Contains(column_id));
                selected_columns.Add(column_id);
                Debug.WriteLine(column_id);*/


                bool error_placement = false;
                int tries_count = 0;
                while (!error_placement)
                {
                    tries_count++;
                    do
                    {
                        row_id = rand.Next(0, rows);
                    } while (error_cord_list.Contains((row_id, column_id)));


                    if (matrix2d_copy[row_id, column_id - 1] == 1 && matrix2d[row_id, column_id + 1] == 1)
                    {
                        matrix2d[row_id, column_id] = 0;
                        error_placement = true;
                        error_cord_list.Add((row_id, column_id));
                    }
                    else if (matrix2d_copy[row_id, column_id - 1] == 0 && matrix2d[row_id, column_id + 1] == 0)
                    {
                        matrix2d[row_id, column_id] = 1;
                        error_placement = true;
                        error_cord_list.Add((row_id, column_id));
                    }
                    else if (tries_count > rows)
                    {
                        Debug.WriteLine("fail");
                        break;
                    }
                }


            }
            Debug.WriteLine($" columns: { selected_columns.Count}");
        }
        public void Randomize_columns_in_matrix()
        {
            var rand = new Random();
            List<int> selected_columns = new List<int>();
            List<int> random_places = new List<int>();
            int column_id;
            int random_place;
            int[,] temp_matrix = new int[rows, columns];
            temp_matrix = matrix2d.Clone() as int[,];
            for (int i = 0; i < columns; i++)
            {
                do
                {
                    column_id = rand.Next(0, columns);
                } while (selected_columns.Contains(column_id));
                selected_columns.Add(column_id);
                do
                {
                    random_place = rand.Next(0, columns);
                } while (random_places.Contains(random_place));
                random_places.Add(random_place);

                for (int j = 0; j < rows; j++)
                {
                    matrix2d[j, random_place] = temp_matrix[j, column_id];
                }
            }


        }
        public string Debug_to_string()
        {
            string matrix_string = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix_string += matrix2d[i, j].ToString();
                    matrix_string += " ";
                }
                matrix_string += Environment.NewLine;
            }

            return matrix_string;
        }

        public string Debug_columns_to_string()
        {
            string columns_string = "";
            for(int i = 0; i < columns_ids.Length; i++)
            {
                columns_string += columns_ids[i].ToString();
                columns_string += " ";
            }
            return columns_string;
        }
        public void Greedy_arrangement()
        {
            //TODO greedy sorting columns by 1
            int[,] temp_matrix = new int[rows, columns];
            temp_matrix = matrix2d.Clone() as int[,];
            //var column_ids_and_ones = new List<(int, int)>();
            List<Tuple<int, int>> column_ids_and_ones = new List<Tuple<int, int>>();

            for (int i = 0; i < temp_matrix.GetLength(1); i++)
            {
                int ones_count = 0;
                for (int j = 0; j < temp_matrix.GetLength(0); j++)
                {
                    if (temp_matrix[j, i] == 1)
                    {
                        ones_count++;
                    }
                }
                column_ids_and_ones.Add(new Tuple<int, int>(i, ones_count));
            }
            column_ids_and_ones = column_ids_and_ones.OrderByDescending(t => t.Item2).ToList();

            for (int i = 0; i < temp_matrix.GetLength(1); i++)
            {
                for (int j = 0; j < temp_matrix.GetLength(0); j++)
                {
                    matrix2d[j, i] = temp_matrix[j, column_ids_and_ones[i].Item1];
                }
            }

            cmax = this.Calculate_cmax(matrix2d);




        }

        private int[] Get_row_from_matrix(int row, int[,] problem_matrix)
        {
            int[] single_row = new int[problem_matrix.GetLength(1)];
            for (int i = 0; i < problem_matrix.GetLength(1); i++)
            {
                single_row[i] = problem_matrix[row, i];
            }
            return single_row;
        }

        private List<int> GetColumnsToRemove(int[] row)
        {
            int removeCount = 0;
            List<(int, int)> sequences = new List<(int, int)>(); // (start of 1s sequence, length of sekuence)
            int sequence_length = 0;
            for (int i = 0; i < row.Length; i++) // saving 1s sequences to list
            {
                if(row[i] == 0)
                {
                    if (sequence_length > 0)
                    {
                        sequences.Add((i-sequence_length,sequence_length));
                        sequence_length = 0;
                    }
                }
                else
                {
                    sequence_length++;
                    if(i == row.Length - 1)
                    {
                        sequences.Add((i-sequence_length+1,sequence_length));
                        sequence_length = 0;
                    }
                }
                /*if (row[i] == 1)
                {

                    sequence_length++;
                    if (i == row.Length - 1)
                    {
                        sequences.Add((i, sequence_length));
                        sequence_length = 0;
                    }
                }
                else
                {
                    if (sequence_length > 0)
                    {
                        sequences.Add((i - sequence_length, sequence_length));
                        sequence_length = 0;
                    }
                }*/
            }
            sequences = sequences.OrderByDescending(t => t.Item2).ToList();
            List<int> columns_to_remove = new List<int>();
            if (sequences.Count == 0)
            {
                return columns_to_remove;
            }
            var longest_sequence = sequences.First();
            sequences.RemoveAt(0);
            //List<int> columns_to_remove = new List<int>();
            bool right_side_more_ones = false;
            bool left_side_more_ones = false;

            while (sequences.Count != 0)
            {
                int max_distance = 0;
                (int, int) furthest_sequence = (-1, -1);
                int furthest_index = 1;
                string side = "";

                for (int i = 0; i < sequences.Count; i++)
                {

                    int current_distance = 0;
                    if (sequences[i].Item1 < longest_sequence.Item1) // if next sequence is on the left
                    {
                        current_distance = longest_sequence.Item1 - sequences[i].Item1;
                        if (current_distance > max_distance)
                        {
                            max_distance = current_distance;
                            furthest_sequence = sequences[i];
                            furthest_index = i;
                            side = "left";

                        }
                    }
                    else // if next sequence is on the right
                    {
                        current_distance = (sequences[i].Item1 + sequences[i].Item2) - (longest_sequence.Item1 + longest_sequence.Item2);
                        if (current_distance > max_distance)
                        {
                            max_distance = current_distance;
                            furthest_sequence = sequences[i];
                            furthest_index = i;
                            side = "right";

                        }
                    }
                }
                sequences.RemoveAt(furthest_index);

                int ones_count = 0;
                int zeroes_count = 0;
                if (side == "right")
                {
                    for (int i = longest_sequence.Item1 + (longest_sequence.Item2-1); i < furthest_sequence.Item1 + (furthest_sequence.Item2 - 1); i++)
                    {
                        if (row[i] == 1)
                        {
                            ones_count++;
                        }
                        else
                        {
                            zeroes_count++;
                        }
                    }

                }
                else
                {
                    for (int i = furthest_sequence.Item1; i < longest_sequence.Item1; i++)
                    {
                        if (row[i] == 1)
                        {
                            ones_count++;
                        }
                        else
                        {
                            zeroes_count++;
                        }
                    }

                }

                if (zeroes_count > ones_count) //more 0's than 1's
                {
                    if (side == "left" && left_side_more_ones != true)
                    {
                        for (int i = furthest_sequence.Item1; i < (furthest_sequence.Item1 + furthest_sequence.Item2); i++)
                        {
                            columns_to_remove.Add(i);
                            removeCount++;
                        }
                    }

                    if (side == "right" && right_side_more_ones != true)
                    {
                        for (int i = furthest_sequence.Item1; i < (furthest_sequence.Item1 + furthest_sequence.Item2); i++)
                        {
                            columns_to_remove.Add(i);
                            removeCount++;
                        }
                    }

                }
                else // more 1's than 0's
                {
                    if (side == "left")
                    {
                        for (int i = furthest_sequence.Item1; i < longest_sequence.Item1; i++)
                        {
                            if (row[i] == 0)
                            {
                                columns_to_remove.Add(i);
                                removeCount++;
                            }
                        }
                        left_side_more_ones = true;
                    }
                    else
                    {

                        for (int i = (longest_sequence.Item1 + longest_sequence.Item2); i < furthest_sequence.Item1; i++)
                        {
                            if (row[i] == 0)
                            {
                                columns_to_remove.Add(i);
                                removeCount++;
                            }
                        }
                        right_side_more_ones = true;
                    }
                }

            }
            columns_to_remove = columns_to_remove.Distinct().ToList();
            //Debug.WriteLine("total: ");
            //Debug.WriteLine(removeCount);
            //Debug.WriteLine("columns to remove:");
            //columns_to_remove.ForEach(item => Debug.WriteLine(item));
            //Debug.WriteLine("-----------------------------");

            return columns_to_remove;
        }

        private List<List<int>> Get_columns_to_remove_in_matrix(int[,] problem_matrix){
            int[,] temp_matrix = new int[rows, columns];
            temp_matrix = problem_matrix.Clone() as int[,];
            List<List<int>> remove_per_row = new List<List<int>>();
            for (int i = 0; i < temp_matrix.GetLength(0); i++)
            {
                remove_per_row.Add(GetColumnsToRemove(Get_row_from_matrix(i,temp_matrix)));
            }
            remove_per_row = remove_per_row.OrderByDescending(t => t.Count).ToList();
            for(int i = 0; i< remove_per_row.Count; i++)
            {
                if(remove_per_row[i].Count == 0)
                {
                    remove_per_row.RemoveAt(i);
                    i--;
                }
            }
            return remove_per_row; 
        }
        
        private int[,] remove_columns_from_matrix(List<int>columns_to_remove, int[,] my_matrix)
        {
            int[,] matrix_after_removal = new int[my_matrix.GetLength(0), my_matrix.GetLength(1) - columns_to_remove.Count];

            for(int i = 0; i< matrix_after_removal.GetLength(0); i++)
            {
                int j = 0;
                for(int k = 0; k< my_matrix.GetLength(1); k++)
                {
                    if (columns_to_remove.Contains(k))
                    {
                        continue;   
                    }
                    matrix_after_removal[i, j] = my_matrix[i, k];
                    j++;
                }
            }
            return matrix_after_removal;
        }

        private int[] remove_columns_from_columns_ids(List<int> columns_to_remove, int[] column_ids)
        {
            int[] columns_after_removal = new int[column_ids.Length - columns_to_remove.Count];
            int j = 0;
  
            
            for(int i = 0; i <= column_ids.Length; i++)
            {
                if (columns_to_remove.Contains(i))
                {
                    continue;
                }
                columns_after_removal[j] = column_ids[i];
                j++;
                if(j == columns_after_removal.Length)
                {
                    return columns_after_removal;
                }
                
            }
            return columns_after_removal;
        }


        public int Calculate_cmax(int[,] matrix)
        { 
            int[,] temp_matrix = new int[rows, columns];
            temp_matrix = matrix.Clone() as int[,];
            int[] temp_columns_ids = columns_ids; //Enumerable.Range(0, temp_matrix.GetLength(1)).ToArray();
            List<List<int>> all_columns_to_delete = new List<List<int>>();
            

            bool continue_removal = true;
            while (continue_removal)
            {
                all_columns_to_delete = Get_columns_to_remove_in_matrix(temp_matrix);
                if (all_columns_to_delete.Count == 0)
                {
                    continue_removal = false;
                    break;
                }
                temp_matrix = remove_columns_from_matrix(all_columns_to_delete.Last(), temp_matrix);
                temp_columns_ids = remove_columns_from_columns_ids(all_columns_to_delete.Last(), temp_columns_ids);
            }

            //GetColumnsToRemove(new int[]{ 0 ,1, 0, 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1 ,0 ,0});
            //CountColumnsToRemove(new int[] { 0,1,1,1,0,0,1,1,1,0,0,0,1,0 });

            //CountColumnsToRemove(new int[] { 1, 1, 0, 0, 1, 1, 0 });
            //CountColumnsToRemove(new int[] { 1, 0, 0, 1, 1, 1, 1 });
            //CountColumnsToRemove(new int[] { 0, 0, 1, 1, 1, 0, 0 });
            //CountColumnsToRemove(new int[] { 0, 0, 1, 0, 1, 0, 1 }); // error
            //CountColumnsToRemove(new int[] { 1, 1, 1, 1, 1, 1, 1 });

            //CountColumnsToRemove(new int[] { 0,1,0,0,1,1,1,1,0,0,1,1,1,1,0,0,1 }); // error!!!
            //CountColumnsToRemove(new int[] { 0,1,1,1,1,0,0,1,0,0,1,1,1,1,0,0,1,0 });
            //CountColumnsToRemove(new int[] { 1,0,0,1,1,1,1,1,0,0,1,0,0,1,1,1,1,0,0,1,0 });

            columns_left = temp_columns_ids.Clone() as int[];
            this.cmax = (matrix2d.GetLength(1) - temp_matrix.GetLength(1));
            return (matrix2d.GetLength(1) - temp_matrix.GetLength(1));
        }

        public void Switch_columns(int first_column_id, int second_column_id)
        {
            int[] temp_first_column_content = new int[rows];
            int[] temp_second_column_content = new int[rows];
            int id_first = -1;
            int id_second = -1;
            for (int i = 0; i < columns; i++)
            {
                if(columns_ids[i] == first_column_id)
                {
                    id_first = columns_ids[i];
                    for(int j=0; j< rows; j++)
                    {
                        temp_first_column_content[j] = matrix2d[j,columns_ids[i]];
                    }
                }else if(columns_ids[i] == second_column_id)
                {
                    id_second = columns_ids[i];
                    for (int j = 0; j < rows; j++)
                    {
                        temp_second_column_content[j] = matrix2d[j, columns_ids[i]];
                    }
                }
            }

            for (int i = 0; i < columns; i++)
            {
                if (columns_ids[i] == first_column_id)
                {
                    
                    for (int j = 0; j < rows; j++)
                    {
                        matrix2d[j, columns_ids[i]] = temp_second_column_content[j];
                    }
                    columns_ids[i] = id_second;
                }
                else if (columns_ids[i] == second_column_id)
                {
                    
                    for (int j = 0; j < rows; j++)
                    {
                        matrix2d[j, columns_ids[i]] = temp_first_column_content[j];
                    }
                    columns_ids[i] = id_first;
                }
            }

        }
        public int[,] Get_matrix()
        {
            return matrix2d;
        }

        public void Set_matrix(int[,] matrix)
        {
            matrix2d = matrix.Clone() as int[,];
        }
        public string Get_final_columns()
        {
            string columns_string = "";
            for (int i = 0; i < columns_left.Length; i++)
            {
                columns_string += columns_left[i].ToString();
                columns_string += " ";
            }
            return columns_string;
        }
        public int Get_no_columns()
        {
            return columns;
        }
        public int Get_no_rows()
        {
            return rows;
        }

        public int[] Get_columns_order()
        {
            return columns_ids;
        }

        public int Get_cmax()
        {
            return cmax;
        }

        public int Get_cmax_estimation()
        {
            return cmax_estimation;
        }

        public void Load_from_file()
        {

        }
    }
}

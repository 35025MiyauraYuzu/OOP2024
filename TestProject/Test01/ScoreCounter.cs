using System.Collections.Generic;
using System.IO;
using System;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 生徒のデータを読み込み、オブジェクトを返す    
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] lins = File.ReadAllLines(filePath);
            foreach (var line in lins) {
                string[] item = line.Split(',');
                Student student = new Student {
                    Name = item[0],
                    Subject = item[1],
                    Score = int.Parse(item[2])
                };
                students.Add(student);
            }
            return students;
        }

        //メソッドの概要： 生徒別点数を集計
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Name)) {
                    dict[student.Name] += student.Score;
                } else {
                    dict[student.Name] = student.Score;
                }
                return dict;

            }
        }
    }
}

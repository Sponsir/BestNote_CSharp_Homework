using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace BestNote_cs
{
    public class DataManagerByMySQL : DataManager
    {
        private string user = "best_note";
        private string pwd = "bestbest";
        private string database = "best_note";

        private MySqlConnection connection;

        public DataManagerByMySQL()
        {
            string connectStr = "server=localhost;user=" + user + ";database=" + database + ";password=" + pwd + ";";
            connection = new MySqlConnection(connectStr);

            connection.Open();
        }

        private int getFolderId(string folderName)
        {
            string sql = "select folder_id from folder where folder_name = '" + folderName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int folderId = (int)reader[0];
            reader.Close();
            return folderId;
        }

        public override FileStructure getFileContent(string fileName, string folderName)
        {
            int folderId = getFolderId(folderName);

            string sql = "select file_content, create_time, modify_time from file_content where folder_id = "
                + folderId + " and file_name = '" + fileName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            FileStructure file = new FileStructure();
            file.content = (string)reader[0];
            file.createTime = (DateTime)reader[1];
            file.modifyTime = (DateTime)reader[2];
            reader.Close();
            return file;
        }

        public override ArrayList getFileList(string folderName)
        {
            int folderId = getFolderId(folderName);

            string sql = "select file_name from file_content where folder_id = " + folderId;
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            ArrayList fileList = new ArrayList();
            while (reader.Read())
            {
                fileList.Add(reader[0]);
            }
            reader.Close();
            return fileList;
        }

        public override ArrayList getFolderList()
        {            
            string sql = "select folder_name from folder";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            ArrayList folderList = new ArrayList();
            while (reader.Read())
            {
                folderList.Add(reader[0]);
            }
            reader.Close();
            return folderList;
        }

        public override bool newFolder(string folderName)
        {
            string sql = "insert into folder (folder_name) values ('" + folderName + "')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try {
                int isSuccess = cmd.ExecuteNonQuery();
                if (isSuccess == 0)
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        public override bool newFile(string fileName, string folderName, string fileContent)
        {
            int folderId = getFolderId(folderName);

            string sql = "insert into file_content (folder_id, file_name, file_content) values (" + folderId
                + ", '" + fileName + "', '" + fileContent + "')";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try
            {
                int isSuccess = cmd.ExecuteNonQuery();
                if (isSuccess == 0)
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        public override void close()
        {
            connection.Close();
        }

        public override bool updateContent(string fileName, string folderName, string fileContent)
        {
            int folderId = getFolderId(folderName);

            string sql = "update file_content set file_content ='" + fileContent + "' where folder_id=" + folderId
                + " and file_name='" + fileName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            int isSuccess = cmd.ExecuteNonQuery();
            if (isSuccess == 0)
            {
                return false;
            }
            return true;
        }

        public override bool renameFolder(string folderName, string newName)
        {
            string sql = "update folder set folder_name = '" + newName + "' where folder_name = '" + folderName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try {
                int isSuccess = cmd.ExecuteNonQuery();
                if (isSuccess == 0)
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        public override bool deleteFolder(string folderName)
        {
            string sql = "delete from folder where folder_name = '" + folderName + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            int isSuccess = cmd.ExecuteNonQuery();
            if (isSuccess == 0)
            {
                return false;
            }
            return true;
        }

        public override bool renameFile(string fileName, string newName, string folderName)
        {
            int folderId = getFolderId(folderName);
            string sql = "update file_content set file_name = '" + newName + "' where folder_id = "
                + folderId + " and file_name = '" + fileName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            try
            {
                int isSuccess = cmd.ExecuteNonQuery();
                if (isSuccess == 0)
                {
                    return false;
                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        public override bool deleteFile(string fileName, string folderName)
        {
            int folderId = getFolderId(folderName);
            string sql = "delete from file_content where folder_id = " + folderId + " and file_name = '" + fileName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            int isSuccess = cmd.ExecuteNonQuery();
            if (isSuccess == 0)
            {
                return false;
            }
            return true;
        }
    }
}
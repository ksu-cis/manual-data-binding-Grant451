﻿using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        public event EventHandler NoteChanged;//this is a method?


        private string title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title 
        {
            get { return title; }
            set
            {
                if (title == value) return;//good for optimization
                title = value;
                //if(NoteChanged!=null) NoteChanged.Invoke(this, new EventArgs());
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        private string body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body 
        {
            get { return body; }
            set
            {
                if (body == value) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}

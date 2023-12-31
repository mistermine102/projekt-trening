﻿using Guna.UI2.WinForms.Suite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projekt_trening.UserControls
{
    public partial class addExerciseModal : Form
    {
        public event EventHandler exerciseAddedEvent;
        public static bool inEditMode = false;
        public static Exercise exerciseToEdit;
        public addExerciseModal()
        {
            InitializeComponent();

            if(inEditMode)
            {
                prepopulateValues();
                changeLabelsInEditMode();
            }
        }
        async Task addExercise()
        {
            List<string> targetMuscles = new List<string>();

            string[] targetMusclesArr = target_muscles_textbox.Text.Split(',');

            foreach (string muscle in targetMusclesArr)
            {
                targetMuscles.Add(muscle);
            }

            string name = name_textbox.Text;
            string description = desc_textbox.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Nazwa nie może być pusta.");
                return;
            }
            if (description.Length == 0)
            {
                MessageBox.Show("Opis nie może być pusty.");
                return;
            }

            Exercise newExercise = new Exercise()
            {
                name = name,
                description = description,
                imgUrl = img_url_textbox.Text,
                difficulty = 1,
                targetMuscles = targetMuscles
            };

            if(inEditMode)
            {
                newExercise._id = exerciseToEdit._id;
                await Exercise.editExercise(newExercise);
            } else
            {
                await Exercise.createExercise(newExercise);
            }
        }
        void prepopulateValues()
        {
            name_textbox.Text = exerciseToEdit.name;
            desc_textbox.Text = exerciseToEdit.description;
            img_url_textbox.Text = exerciseToEdit.imgUrl;
        }

        void changeLabelsInEditMode()
        {
            title.Text = "Edytuj ćwiczenie";
            add_exercise_btn.Text = "Edytuj";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void add_exercise_btn_Click(object sender, EventArgs e)
        {
            await addExercise();
            exerciseAddedEvent?.Invoke(sender, e);
            this.Close();
        }

        private void addExerciseModal_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void form_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

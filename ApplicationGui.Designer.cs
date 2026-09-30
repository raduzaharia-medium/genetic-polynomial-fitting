namespace FunctionEvolution
{
    partial class ApplicationGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpPopulationSettings = new System.Windows.Forms.GroupBox();
            this.lblAffectedGenes = new System.Windows.Forms.Label();
            this.lblMutationProbability = new System.Windows.Forms.Label();
            this.lblCoefficientCount = new System.Windows.Forms.Label();
            this.lblIndividualCount = new System.Windows.Forms.Label();
            this.numAffectedGenes = new System.Windows.Forms.NumericUpDown();
            this.numMutationProbability = new System.Windows.Forms.NumericUpDown();
            this.numCoefficientCount = new System.Windows.Forms.NumericUpDown();
            this.numIndividualCount = new System.Windows.Forms.NumericUpDown();
            this.webSolutionView = new System.Windows.Forms.WebBrowser();
            this.grpEvolutionControl = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblEvolutionStep = new System.Windows.Forms.Label();
            this.btnEvolve = new System.Windows.Forms.Button();
            this.numGenerations = new System.Windows.Forms.NumericUpDown();
            this.tbcEvolutionDetails = new System.Windows.Forms.TabControl();
            this.tabSolutionsView = new System.Windows.Forms.TabPage();
            this.tabChartView = new System.Windows.Forms.TabPage();
            this.gphChart = new ZedGraph.ZedGraphControl();
            this.grpEvolutionSettings = new System.Windows.Forms.GroupBox();
            this.numCrossoverProbability = new System.Windows.Forms.NumericUpDown();
            this.lblCrossoverProbability = new System.Windows.Forms.Label();
            this.grpPopulationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAffectedGenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoefficientCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividualCount)).BeginInit();
            this.grpEvolutionControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).BeginInit();
            this.tbcEvolutionDetails.SuspendLayout();
            this.tabSolutionsView.SuspendLayout();
            this.tabChartView.SuspendLayout();
            this.grpEvolutionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPopulationSettings
            // 
            this.grpPopulationSettings.Controls.Add(this.lblCoefficientCount);
            this.grpPopulationSettings.Controls.Add(this.lblIndividualCount);
            this.grpPopulationSettings.Controls.Add(this.numCoefficientCount);
            this.grpPopulationSettings.Controls.Add(this.numIndividualCount);
            this.grpPopulationSettings.Location = new System.Drawing.Point(12, 12);
            this.grpPopulationSettings.Name = "grpPopulationSettings";
            this.grpPopulationSettings.Size = new System.Drawing.Size(186, 124);
            this.grpPopulationSettings.TabIndex = 0;
            this.grpPopulationSettings.TabStop = false;
            this.grpPopulationSettings.Text = "Population settings";
            // 
            // lblAffectedGenes
            // 
            this.lblAffectedGenes.AutoSize = true;
            this.lblAffectedGenes.Location = new System.Drawing.Point(6, 73);
            this.lblAffectedGenes.Name = "lblAffectedGenes";
            this.lblAffectedGenes.Size = new System.Drawing.Size(127, 13);
            this.lblAffectedGenes.TabIndex = 3;
            this.lblAffectedGenes.Text = "Genes affected by mutation";
            // 
            // lblMutationProbability
            // 
            this.lblMutationProbability.AutoSize = true;
            this.lblMutationProbability.Location = new System.Drawing.Point(6, 47);
            this.lblMutationProbability.Name = "lblMutationProbability";
            this.lblMutationProbability.Size = new System.Drawing.Size(123, 13);
            this.lblMutationProbability.TabIndex = 3;
            this.lblMutationProbability.Text = "Mutation probability";
            // 
            // lblCoefficientCount
            // 
            this.lblCoefficientCount.AutoSize = true;
            this.lblCoefficientCount.Location = new System.Drawing.Point(6, 47);
            this.lblCoefficientCount.Name = "lblCoefficientCount";
            this.lblCoefficientCount.Size = new System.Drawing.Size(104, 13);
            this.lblCoefficientCount.TabIndex = 3;
            this.lblCoefficientCount.Text = "Number of coefficients";
            // 
            // lblIndividualCount
            // 
            this.lblIndividualCount.AutoSize = true;
            this.lblIndividualCount.Location = new System.Drawing.Point(6, 21);
            this.lblIndividualCount.Name = "lblIndividualCount";
            this.lblIndividualCount.Size = new System.Drawing.Size(87, 13);
            this.lblIndividualCount.TabIndex = 2;
            this.lblIndividualCount.Text = "Number of individuals";
            // 
            // numAffectedGenes
            // 
            this.numAffectedGenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numAffectedGenes.Location = new System.Drawing.Point(152, 71);
            this.numAffectedGenes.Name = "numAffectedGenes";
            this.numAffectedGenes.Size = new System.Drawing.Size(65, 20);
            this.numAffectedGenes.TabIndex = 3;
            this.numAffectedGenes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numAffectedGenes.ValueChanged += new System.EventHandler(this.UpdateAlgorithmConfiguration);
            // 
            // numMutationProbability
            // 
            this.numMutationProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMutationProbability.DecimalPlaces = 1;
            this.numMutationProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numMutationProbability.Location = new System.Drawing.Point(152, 45);
            this.numMutationProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMutationProbability.Name = "numMutationProbability";
            this.numMutationProbability.Size = new System.Drawing.Size(65, 20);
            this.numMutationProbability.TabIndex = 3;
            this.numMutationProbability.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.numMutationProbability.ValueChanged += new System.EventHandler(this.UpdateAlgorithmConfiguration);
            // 
            // numCoefficientCount
            // 
            this.numCoefficientCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCoefficientCount.Location = new System.Drawing.Point(115, 45);
            this.numCoefficientCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCoefficientCount.Name = "numCoefficientCount";
            this.numCoefficientCount.Size = new System.Drawing.Size(65, 20);
            this.numCoefficientCount.TabIndex = 1;
            this.numCoefficientCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCoefficientCount.ValueChanged += new System.EventHandler(this.UpdateAlgorithmConfiguration);
            // 
            // numIndividualCount
            // 
            this.numIndividualCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numIndividualCount.Location = new System.Drawing.Point(115, 19);
            this.numIndividualCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numIndividualCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIndividualCount.Name = "numIndividualCount";
            this.numIndividualCount.Size = new System.Drawing.Size(65, 20);
            this.numIndividualCount.TabIndex = 0;
            this.numIndividualCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numIndividualCount.ValueChanged += new System.EventHandler(this.UpdateAlgorithmConfiguration);
            // 
            // webSolutionView
            // 
            this.webSolutionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSolutionView.Location = new System.Drawing.Point(3, 3);
            this.webSolutionView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSolutionView.Name = "webSolutionView";
            this.webSolutionView.Size = new System.Drawing.Size(681, 235);
            this.webSolutionView.TabIndex = 0;
            // 
            // grpEvolutionControl
            // 
            this.grpEvolutionControl.Controls.Add(this.btnStop);
            this.grpEvolutionControl.Controls.Add(this.btnStart);
            this.grpEvolutionControl.Controls.Add(this.lblEvolutionStep);
            this.grpEvolutionControl.Controls.Add(this.btnEvolve);
            this.grpEvolutionControl.Controls.Add(this.numGenerations);
            this.grpEvolutionControl.Location = new System.Drawing.Point(433, 12);
            this.grpEvolutionControl.Name = "grpEvolutionControl";
            this.grpEvolutionControl.Size = new System.Drawing.Size(144, 124);
            this.grpEvolutionControl.TabIndex = 3;
            this.grpEvolutionControl.TabStop = false;
            this.grpEvolutionControl.Text = "Evolution control";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(73, 95);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 95);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(61, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblEvolutionStep
            // 
            this.lblEvolutionStep.AutoSize = true;
            this.lblEvolutionStep.Location = new System.Drawing.Point(6, 24);
            this.lblEvolutionStep.Name = "lblEvolutionStep";
            this.lblEvolutionStep.Size = new System.Drawing.Size(65, 13);
            this.lblEvolutionStep.TabIndex = 6;
            this.lblEvolutionStep.Text = "Evolution step";
            // 
            // btnEvolve
            // 
            this.btnEvolve.Location = new System.Drawing.Point(6, 66);
            this.btnEvolve.Name = "btnEvolve";
            this.btnEvolve.Size = new System.Drawing.Size(126, 23);
            this.btnEvolve.TabIndex = 5;
            this.btnEvolve.Text = "Evolve one step";
            this.btnEvolve.UseVisualStyleBackColor = true;
            this.btnEvolve.Click += new System.EventHandler(this.btnEvolve_Click);
            // 
            // numGenerations
            // 
            this.numGenerations.Location = new System.Drawing.Point(77, 21);
            this.numGenerations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGenerations.Name = "numGenerations";
            this.numGenerations.Size = new System.Drawing.Size(58, 20);
            this.numGenerations.TabIndex = 4;
            this.numGenerations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbcEvolutionDetails
            // 
            this.tbcEvolutionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcEvolutionDetails.Controls.Add(this.tabSolutionsView);
            this.tbcEvolutionDetails.Controls.Add(this.tabChartView);
            this.tbcEvolutionDetails.Location = new System.Drawing.Point(12, 142);
            this.tbcEvolutionDetails.Name = "tbcEvolutionDetails";
            this.tbcEvolutionDetails.SelectedIndex = 0;
            this.tbcEvolutionDetails.Size = new System.Drawing.Size(695, 267);
            this.tbcEvolutionDetails.TabIndex = 4;
            // 
            // tabSolutionsView
            // 
            this.tabSolutionsView.Controls.Add(this.webSolutionView);
            this.tabSolutionsView.Location = new System.Drawing.Point(4, 22);
            this.tabSolutionsView.Name = "tabSolutionsView";
            this.tabSolutionsView.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolutionsView.Size = new System.Drawing.Size(687, 241);
            this.tabSolutionsView.TabIndex = 0;
            this.tabSolutionsView.Text = "Solutions view";
            this.tabSolutionsView.UseVisualStyleBackColor = true;
            // 
            // tabChartView
            // 
            this.tabChartView.Controls.Add(this.gphChart);
            this.tabChartView.Location = new System.Drawing.Point(4, 22);
            this.tabChartView.Name = "tabChartView";
            this.tabChartView.Padding = new System.Windows.Forms.Padding(3);
            this.tabChartView.Size = new System.Drawing.Size(687, 241);
            this.tabChartView.TabIndex = 1;
            this.tabChartView.Text = "Chart view";
            this.tabChartView.UseVisualStyleBackColor = true;
            // 
            // gphChart
            // 
            this.gphChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gphChart.Location = new System.Drawing.Point(3, 3);
            this.gphChart.Name = "gphChart";
            this.gphChart.ScrollMaxX = 0;
            this.gphChart.ScrollMaxY = 0;
            this.gphChart.ScrollMaxY2 = 0;
            this.gphChart.ScrollMinX = 0;
            this.gphChart.ScrollMinY = 0;
            this.gphChart.ScrollMinY2 = 0;
            this.gphChart.Size = new System.Drawing.Size(681, 235);
            this.gphChart.TabIndex = 0;
            // 
            // grpEvolutionSettings
            // 
            this.grpEvolutionSettings.Controls.Add(this.lblCrossoverProbability);
            this.grpEvolutionSettings.Controls.Add(this.numCrossoverProbability);
            this.grpEvolutionSettings.Controls.Add(this.lblAffectedGenes);
            this.grpEvolutionSettings.Controls.Add(this.lblMutationProbability);
            this.grpEvolutionSettings.Controls.Add(this.numMutationProbability);
            this.grpEvolutionSettings.Controls.Add(this.numAffectedGenes);
            this.grpEvolutionSettings.Location = new System.Drawing.Point(204, 12);
            this.grpEvolutionSettings.Name = "grpEvolutionSettings";
            this.grpEvolutionSettings.Size = new System.Drawing.Size(223, 124);
            this.grpEvolutionSettings.TabIndex = 5;
            this.grpEvolutionSettings.TabStop = false;
            this.grpEvolutionSettings.Text = "Evolution settings";
            // 
            // numCrossoverProbability
            // 
            this.numCrossoverProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCrossoverProbability.DecimalPlaces = 1;
            this.numCrossoverProbability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCrossoverProbability.Location = new System.Drawing.Point(152, 19);
            this.numCrossoverProbability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrossoverProbability.Name = "numCrossoverProbability";
            this.numCrossoverProbability.Size = new System.Drawing.Size(65, 20);
            this.numCrossoverProbability.TabIndex = 4;
            this.numCrossoverProbability.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.numCrossoverProbability.ValueChanged += new System.EventHandler(this.UpdateAlgorithmConfiguration);
            // 
            // lblCrossoverProbability
            // 
            this.lblCrossoverProbability.AutoSize = true;
            this.lblCrossoverProbability.Location = new System.Drawing.Point(6, 23);
            this.lblCrossoverProbability.Name = "lblCrossoverProbability";
            this.lblCrossoverProbability.Size = new System.Drawing.Size(140, 13);
            this.lblCrossoverProbability.TabIndex = 5;
            this.lblCrossoverProbability.Text = "Crossover probability";
            // 
            // ApplicationGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 421);
            this.Controls.Add(this.grpEvolutionSettings);
            this.Controls.Add(this.tbcEvolutionDetails);
            this.Controls.Add(this.grpEvolutionControl);
            this.Controls.Add(this.grpPopulationSettings);
            this.Name = "ApplicationGui";
            this.Text = "Function evolution";
            this.grpPopulationSettings.ResumeLayout(false);
            this.grpPopulationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAffectedGenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMutationProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoefficientCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividualCount)).EndInit();
            this.grpEvolutionControl.ResumeLayout(false);
            this.grpEvolutionControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGenerations)).EndInit();
            this.tbcEvolutionDetails.ResumeLayout(false);
            this.tabSolutionsView.ResumeLayout(false);
            this.tabChartView.ResumeLayout(false);
            this.grpEvolutionSettings.ResumeLayout(false);
            this.grpEvolutionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossoverProbability)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPopulationSettings;
        private System.Windows.Forms.NumericUpDown numIndividualCount;
        private System.Windows.Forms.NumericUpDown numCoefficientCount;
        private System.Windows.Forms.Label lblCoefficientCount;
        private System.Windows.Forms.Label lblIndividualCount;
        private System.Windows.Forms.Label lblMutationProbability;
        private System.Windows.Forms.NumericUpDown numAffectedGenes;
        private System.Windows.Forms.NumericUpDown numMutationProbability;
        private System.Windows.Forms.Label lblAffectedGenes;
        private System.Windows.Forms.GroupBox grpEvolutionControl;
        private System.Windows.Forms.WebBrowser webSolutionView;
        private System.Windows.Forms.Button btnEvolve;
        private System.Windows.Forms.NumericUpDown numGenerations;
        private System.Windows.Forms.Label lblEvolutionStep;
        private System.Windows.Forms.TabControl tbcEvolutionDetails;
        private System.Windows.Forms.TabPage tabSolutionsView;
        private System.Windows.Forms.TabPage tabChartView;
        private ZedGraph.ZedGraphControl gphChart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpEvolutionSettings;
        private System.Windows.Forms.Label lblCrossoverProbability;
        private System.Windows.Forms.NumericUpDown numCrossoverProbability;
    }
}
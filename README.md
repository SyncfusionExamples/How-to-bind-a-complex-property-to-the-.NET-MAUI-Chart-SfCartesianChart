# How-to-bind-a-complex-property-to-the-.NET-MAUI-Chart-SfCartesianChart
This sample demonstrate how to bind a complex property in.NET MAUI Chart (SfCartesianChart)
# How-to-bind-a-complex-property-to-the-.NET-MAUI-Chart-SfCartesianChart
This sample demonstrate how to bind a complex property in.NET MAUI Chart (SfCartesianChart)
The .NET MAUI Chart provides support for binding the complex property in Cartesian chart. The complex property binding feature enables you to access nested object reference property values to render the chart segment. This article explains how to bind the complex property in the SfCartesianChart, as shown in the following code example.

##[Xaml]
````
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <chart:SfCartesianChart>
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis>
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle 
                        FontAttributes="Bold" Text="Month" />
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.XAxes>
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis Minimum="0" Maximum="100" >
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle 
                        FontAttributes="Bold" Text="Percentage" />
                </chart:NumericalAxis.Title>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>
        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend/>
        </chart:SfCartesianChart.Legend>
        <chart:LineSeries ItemsSource="{Binding Data}" 
                          XBindingPath="Month" 
        YBindingPath="SalesAndExpenseObject.ProfitDetailsObject.ProfitPercentage" 
                          Label="Profit" ShowDataLabels="True" />
        <chart:LineSeries ItemsSource="{Binding Data}" 
                          XBindingPath="Month" 
        YBindingPath="SalesAndExpenseObject.SalesRate[0]"
                          Label="Sales" ShowDataLabels="True" />
        <chart:LineSeries ItemsSource="{Binding Data}" 
                          XBindingPath="Month" 
                          YBindingPath="SalesAndExpenseObject.ExpenseRate" 
                          Label="Expenditure" 
                          ShowDataLabels="True" />
    </chart:SfCartesianChart>
````
##[C#]
````
SfCartesianChart chart = new SfCartesianChart();

chart.BindingContext = new ViewModel();

        CategoryAxis primaryAxis = new CategoryAxis()
        {
            Title = new ChartAxisTitle()
            {
                Text = "Month",
                FontAttributes = FontAttributes.Bold,
            },
        };
        chart.XAxes.Add(primaryAxis);
        NumericalAxis secondaryAxis = new NumericalAxis()
        {
            Title = new ChartAxisTitle()
            {
                Text = "Percentage",
                FontAttributes = FontAttributes.Bold,
            },
            Minimum = 0,
            Maximum = 100,
        };
        chart.YAxes.Add(secondaryAxis);
        ChartLegend chartLegend = new ChartLegend();
        chart.Legend = chartLegend;
        LineSeries seriesOne = new LineSeries()
        {
            XBindingPath = "Month",
            YBindingPath = "SalesAndExpenseObject.ProfitDetailsObject.ProfitPercentage",
            ItemsSource = (new ViewModel()).Data,
            ShowDataLabels = true,
            Label = "Profit",
        };
        LineSeries seriesTwo = new LineSeries()
        {
            XBindingPath = "Month",
            YBindingPath = "SalesAndExpenseObject.SalesRate[0]",
            ItemsSource = (new ViewModel()).Data,
            ShowDataLabels = true,
            Label = "Sales",
        };
        LineSeries seriesThree = new LineSeries()
        {
            XBindingPath = "Month",
            YBindingPath = "SalesAndExpenseObject.ExpenseRate",
            ItemsSource = (new ViewModel()).Data,
            ShowDataLabels = true,
            Label = "Expenditure",
        };
        chart.Series.Add(seriesOne);
        chart.Series.Add(seriesTwo);
        chart.Series.Add(seriesThree);
        this.Content = chart;
````

##Output

![CurrentOutput](https://user-images.githubusercontent.com/105482474/210162317-8d8f131a-829e-4793-84b2-628702d22b42.png)

##See Also

[How to bind array collection to .NET MAUI ChartS (SfCartesianChart)](https://www.syncfusion.com/kb/13734/how-to-bind-array-collection-to-net-maui-chart-sfcartesianchart)

[How to bind the SQLite Database to the .NET MAUI Chart (SfCartesianChart)](https://www.syncfusion.com/kb/13690/how-to-bind-the-sqlite-database-to-the-net-maui-chart-sfcartesianchart)
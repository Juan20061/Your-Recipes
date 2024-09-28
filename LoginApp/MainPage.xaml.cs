using System.Collections.ObjectModel;
using System.ComponentModel;
using LoginApp.Models;
using YourRecipes.Models;
using YourRecipes.Pages;

namespace LoginApp
{
    public partial class MainPage : INotifyPropertyChanged
    {
        public ObservableCollection<Recipes> Recetas { get; set; } //Colección Recipes
        public ObservableCollection<Recipes> Recetas2 { get; set; } //Colección para orden diferente
        
        public MainPage()
        {
            InitializeComponent();
            //InitializeRecipes();
            BindingContext = this;

            Recetas = new ObservableCollection<Recipes>
            {
                //RECETA 1
            new Recipes
            {
                Name = "Waffle con frutos rojos",
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "waffle.jfif",
                Description = "Waffle con frutos rojos",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "2/3 tazas de harina", IsCompleted = false},
                    new Ingredients {NameIngr = "6 cucharadas de azúcar", IsCompleted = false },
                    new Ingredients {NameIngr = "2 cucharadas de harina integral", IsCompleted = false },
                    new Ingredients {NameIngr = "1 1/2 cucharadas de polvo para hornear", IsCompleted = false},
                    new Ingredients {NameIngr = "2 cucharadas de jengibre en polvo", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharada de canela en polvo", IsCompleted = false},
                    new Ingredients {NameIngr = "1 pizca de sal", IsCompleted = false},
                    new Ingredients { NameIngr = "1 pizca de pimienta", IsCompleted = false},
                    new Ingredients { NameIngr = "1/2 cucharaditas de clavo", IsCompleted = false},
                    new Ingredients { NameIngr = "3/4 tazas de leche de vaca", IsCompleted = false},
                    new Ingredients { NameIngr = "1 cucharada de jugo de limón", IsCompleted = false},
                    new Ingredients { NameIngr = "2 cucharadas de miel", IsCompleted = false},
                    new Ingredients { NameIngr = "1 huevo", IsCompleted = false},
                    new Ingredients { NameIngr = "2 cucharadas de mantequilla sin sal", IsCompleted = false},
                    new Ingredients { NameIngr = "Spray para cocinar", IsCompleted = false},
                    new Ingredients { NameIngr = "Pocos de azúcar glass", IsCompleted = false},
                    new Ingredients { NameIngr = "Fresas", IsCompleted = false},
                    new Ingredients { NameIngr = "Zarzamoras", IsCompleted = false},
                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "Mientras tanto mezcle en un recipiente hondo el harina, el azúcar, el harina integral, el polvo para hornear, el jengibre en polvo, la canela, la sal, la pimienta, y el clavo.", IsCompleted = false},
                    new Steps {Description = "En un recipiente pequeño mezcle la leche con el jugo de limón y permita que descanse por 5 minutos.", IsCompleted = false},
                    new Steps {Description = "Agregue la leche, la miel y los huevos a la mezcla de harina y mezcle bien con un batidor.", IsCompleted = false},
                    new Steps {Description = "Agregue la mantequilla.", IsCompleted = false},
                    new Steps {Description = "Engrase su wafflera con espray para cocina y caliente por 2-3 minutos.", IsCompleted = false},
                    new Steps {Description = "Haga los waffles, hasta que estén ligeramente dorados. Mientras cocina el resto de la masa tape los que ya hiso para que no se enfríen.", IsCompleted = false},
                    new Steps {Description = "Por último espolvoree azúcar glass encima de ellos y agregue los frutos rojos.", IsCompleted = false}
                },
                
            },
            //RECETA 2
            new Recipes
            {
                Name = "Postre Tres Leches",
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "pastel_tres_leches.jpg",
                Description = "Postre de tres leches",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "9 huevos", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharada de vainilla", IsCompleted = false},
                    new Ingredients {NameIngr = "3 cucharadas de polvo para hornear", IsCompleted = false},
                    new Ingredients {NameIngr = "1 lata de leche condensada", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 de taza de crema", IsCompleted = false},
                    new Ingredients {NameIngr = "1 lata de leche evaporada", IsCompleted = false},
                    new Ingredients {NameIngr = "2 tazas de harina", IsCompleted = false},
                    new Ingredients {NameIngr = "1 1/2 tazas de azúcar", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 litro de leche", IsCompleted = false},
                    new Ingredients {NameIngr = "1 taza de azúcar glass", IsCompleted = false}
                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "Pre-calienta el horno a 180ºC. Separa 6 claras de las yemas en diferentes bowls. Bate 6 claras a punto de turrón con una batidora eléctrica (es muy importante que queden a punto de turrón antes de agregar los demás ingredientes) , una vez que estén agrega el azúcar poco a poco sin dejar de batir.", IsCompleted = false},
                    new Steps {Description = "Bate las 6 yemas con un tenedor y añádelas a la mezcla. Agrega el harina y la leche y bate hasta que quede una mezcla homogénea.", IsCompleted = false},
                    new Steps {Description = "Enmantequilla y enharina el molde que vas a utilizar. Vacía la mezcla del pastel en el molde para que quede 3/4 lleno. Mételo al horno de 30 a 40 minutos (sin abrir el horno, siempre estar vigilándolo) o hasta que al meter un palillo este salga limpio.", IsCompleted = false},
                    new Steps {Description = "Mientras que se está horneando, mezcla en la batidora o licuadora las tres leches (leche condensada, leche evaporada y crema) y una yema (la clara la deberás de reservar para el betún)", IsCompleted = false},
                    new Steps {Description = "Una vez que esté listo el pastel sácalo del horno y mientras está caliente, pícalo con un tenedor por todos lados y agrega encima la mezcla de las tres leches.", IsCompleted = false},
                    new Steps {Description = "Para el merengue: Bate 3 claras a punto de turrón una vez que estén ve agregando el azúcar glass poco a poco.", IsCompleted = false},
                    new Steps {Description = "Una vez que el pastel esté completamente frío decora el pastel con el merengue.", IsCompleted = false}                },
            },
            //RECETA 3
            new Recipes 
            {
                Name = "Brazo Gitano de Crema", 
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "brazo_gitano.jpg", 
                Description = "Brazo gitano de crema",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "6 Huevos", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 tazas de azúcar, para las claras", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 tazas de azúcar, para las yemas", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharada de ralladura de naranja", IsCompleted = false},
                    new Ingredients {NameIngr = "1 taza de harina", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 tazas de mantequilla, fundida", IsCompleted = false},
                    new Ingredients {NameIngr = "380 gramos de queso crema, (2 paquetes) para el relleno", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 tazas de azúcar glass, para el relleno", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 tazas de crema para batir, para el relleno", IsCompleted = false},
                    new Ingredients {NameIngr = "Azúcar glass al gusto, para decorar", IsCompleted = false},
                    new Ingredients {NameIngr = "Hoja de menta al gusto, para decorar", IsCompleted = false}
                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "Precalienta el horno a 180 °C.", IsCompleted = false},
                    new Steps {Description = "Separa las claras de Huevo de las yemas.", IsCompleted = false},
                    new Steps {Description = "Bate las claras de Huevo con 1/4 de azúcar hasta que doblen su tamaño. Reserva.", IsCompleted = false},
                    new Steps {Description = "Bate las yemas de Huevo con el resto del azúcar y la ralladura de naranja hasta que cambien de color. Integra las claras montadas a las yemas, de manera suave y envolvente pero cuida que no se bajen demasiado.", IsCompleted = false},
                    new Steps {Description = "Con ayuda de un colador, agrega la harina a la preparación anterior y vierte en forma de hilo la mantequilla fundida; mezcla e integra.", IsCompleted = false},
                    new Steps {Description = "Vierte sobre una charola con papel engrasado, extiende con ayuda de una espátula y hornea por 8 minutos.", IsCompleted = false},
                    new Steps {Description = "Retira de horno y coloca el bizcocho sobre un paño con azúcar glass. Enrolla caliente y deja enfriar enrollado.", IsCompleted = false},
                    new Steps {Description = "Para el relleno, bate el queso crema con el azúcar glass hasta integrar completamente, agrega la crema para batir y bate por 3 minuto más.", IsCompleted = false},
                    new Steps {Description = "Desenrolla el bizcocho y unta la mitad de la crema con ayuda de una espátula, hasta cubrir todo el bizcocho y enrolla con cuidado para que no se rompa.", IsCompleted = false},
                    new Steps {Description = "Decora con menta.", IsCompleted = false}
                },
            },
            //RECETA 4
            new Recipes 
            {
                Name = "Churritos Españoles", 
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "churros.jfif", 
                Description = "Churros españoles",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "250 gramos harina de trigo todo uso (también se puede hacer con harina de panadería)", IsCompleted = false},
                    new Ingredients {NameIngr = "250 gramos de agua", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharadita de sal (8 gramos aproximadamente)", IsCompleted = false},
                    new Ingredients {NameIngr = "Azúcar para espolvorear", IsCompleted = false},
                    new Ingredients {NameIngr = "Aceite de oliva suave para freír o aceite de girasol", IsCompleted = false},
                    new Ingredients {NameIngr = "Papel absorbente de cocina", IsCompleted = false},
                    new Ingredients {NameIngr = "Una churrera manual o una manga pastelera con boca fina", IsCompleted = false}


                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "Ponemos la harina en un bol amplio. En una cazuela calentamos el agua con la sal.", IsCompleted = false},
                    new Steps {Description = "Cuando empiece a hervir la vertemos directamente y de una sola vez sobre la harina. Con una cuchara de madera integramos la harina con el agua. Nos quedará una masa muy pegajosa y bastante compacta.", IsCompleted = false},
                    new Steps {Description = "Ahora vamos a introducir esta masa en una churrera o manga pastelera. Este paso es fundamental para que los churros os salgan bien y no tengáis problemas con ellos a la hora de la fritura. La churrera compacta la masa y elimina el aire. Esto evita que los churros luego nos salten en el aceite, por eso es un paso muy importante. Si tenéis máquina para hacer churros la rellenáis con la masa. La mejor opción.", IsCompleted = false},
                    new Steps {Description = "Si no tenéis opción de hacer los churros con churrera, tenemos otra posibilidad, una manga pastelera con una boquilla en forma de estrella. Aunque no es lo recomendable, pues no quedan igual que con churrera. Aún así, hay gente que ha conseguido hacer buenos churros con manga. Las mangas pasteleras pueden ser de plástico desechable. Podéis encontrarlas en tiendas de utensilios de repostería o tiendas online de repostería creativa.", IsCompleted = false},
                    new Steps {Description = "Vamos haciendo las porciones de churros con la masa cruda sobre un paño de cocina en la encimera. En una forma de que se vaya enfriando la masa y evitar que se abran o estallen durante la fritura.", IsCompleted = false},
                    new Steps {Description = "Ponemos al fuego una sartén con abundante aceite de oliva muy suave o aceite de girasol.", IsCompleted = false},
                },
            },


            };

            Recetas2 = new ObservableCollection<Recipes>
            {
                //RECETA 5
            new Recipes 
            {
                Name = "Galletas con Chispas de chocolate", 
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "galletas.jpg", 
                Description = "Galletas con chispas de chocolate",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "1 1/2 tazas de harina", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 cucharada de bicarbonato de sodio ", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 cucharada de sal", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 taza de azúcar morena", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 taza de azúcar", IsCompleted = false},
                    new Ingredients {NameIngr = "1 huevo grande", IsCompleted = false},
                    new Ingredients {NameIngr = "1 barrita de mantequilla derretida (115 grs)", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharadita de vainilla", IsCompleted = false},
                    new Ingredients {NameIngr = "3/4 taza de chispas de chocolate semiamargo", IsCompleted = false}

                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "Precalentar el horno a 180ºC/350ºF. Preparar dos charolas para hornear.", IsCompleted = false},
                    new Steps {Description = "En un tazón grande, colocar la harina con la sal y el bicarbonato. Mezclar con un globo (o un tenedor) vigorosamente, para separar la harina y repartir bien los ingredientes. Agregar los azúcares, mezclar, y agregar el huevo, mantequilla y vainilla. Mezclar muy bien y terminar de incorporar con una espátula.", IsCompleted = false},
                    new Steps {Description = "Agregar las chispas de chocolate, mezclar nuevamente y formar de 16 a 20 bolitas con la masa. Colocar en las charolas aplastando *muy* ligeramente (se expanderán en el horno).", IsCompleted = false},
                    new Steps {Description = "Hornear alrededor de 15 minutos, o hasta que las galletas apenas comiencen a dorar (podrá parecer que les falta cocción pero al sacarlas del horno endurecerán).", IsCompleted = false}
                },
            },
            //RECETA 6
            new Recipes 
            {
                Name = "Pan Integral", 
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "pan.jfif", 
                Description = "Pan integral",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "500 g de harina integral.", IsCompleted = false},
                    new Ingredients {NameIngr = "10 g de levadura seca.", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharada de azúcar.", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharadita de sal.", IsCompleted = false},
                    new Ingredients {NameIngr = "2 cucharadas de aceite de oliva.", IsCompleted = false},
                     new Ingredients {NameIngr = "300 ml de agua tibia.", IsCompleted = false},

                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "En un bol grande, mezcla la harina integral con la sal.", IsCompleted = false},
                    new Steps {Description = "Disuelve el azúcar y la levadura seca en el agua tibia. Espera unos 5 minutos hasta que la mezcla comience a espumar, indicando que la levadura está activa.", IsCompleted = false},
                    new Steps {Description = "Haz un hueco en el centro de la mezcla de harina y añade la mezcla de levadura espumosa, junto con las 2 cucharadas de aceite de oliva.", IsCompleted = false},
                    new Steps {Description = "Comienza a mezclar, agregando gradualmente el resto del agua tibia hasta formar una masa suave que no se pegue a las manos. Es posible que no necesites usar toda el agua o que necesites un poco más, dependiendo de la absorción de la harina.", IsCompleted = false},
                    new Steps {Description = "Amasa la masa sobre una superficie ligeramente enharinada durante unos 10 minutos, hasta que esté suave y elástica.", IsCompleted = false},
                    new Steps {Description = "Coloca la masa en un bol ligeramente aceitado, cúbrela con un paño húmedo y deja reposar en un lugar cálido por aproximadamente 1 hora, o hasta que haya duplicado su tamaño.", IsCompleted = false},
                    new Steps {Description = "Una vez que la masa ha crecido, desgasifícala y forma un pan o varios bollos, según tu preferencia. Colócalos en una bandeja de horno preparada.", IsCompleted = false},
                    new Steps {Description = "Deja reposar los panes formados por unos 10 minutos mientras precalientas el horno a 220°C.", IsCompleted = false},
                    new Steps {Description = "Hornea por unos 20-25 minutos o hasta que el pan esté dorado y suene hueco al golpearlo suavemente en la base.", IsCompleted = false}

                },
            },
            //RECETA 7
            new Recipes 
            { 
                Name = "Budín", 
                ReadTime = new TimeSpan(0, 60, 0),
                ImageSource = "budin.jfif", 
                Description = "Budín",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "2 plátanos maduros", IsCompleted = false},
                    new Ingredients {NameIngr = "8 panes franceses 12 rodajas de pan de caja", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 barrita de margarina", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 taza azúcar para el caramelo", IsCompleted = false},
                    new Ingredients {NameIngr = "2 huevos batidos", IsCompleted = false},
                    new Ingredients {NameIngr = "1 lt leche", IsCompleted = false},
                    new Ingredients {NameIngr = "1/2 taza de azúcar", IsCompleted = false},
                    new Ingredients {NameIngr = "1 pizca sal", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharadita vainilla", IsCompleted = false},
                    new Ingredients {NameIngr = "Canela en polvo", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cda de polvo de hornear", IsCompleted = false}

                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "En una olla o en el molde donde harás el budín haz un caramelo. Agrega a la estufa y deja que se derrita hasta formar un caramelo.", IsCompleted = false},
                    new Steps {Description = "Hidrata los panes con la leche.", IsCompleted = false},
                    new Steps {Description = "Agrega los plátanos al vaso de la licuadora junto con los huevos.", IsCompleted = false},
                    new Steps {Description = "Añade el pan, el azúcar y la sal, y se bate por uno minuto.", IsCompleted = false},
                    new Steps {Description = "Vierte esta mezcla en un molde y espolvorea canela.", IsCompleted = false},
                    new Steps {Description = "Hornea a 350°C por 45 minutos.", IsCompleted = false},
                    new Steps {Description = "Listo. Disfruta", IsCompleted = false}
                },
            },
            //RECETA 8
            new Recipes 
            {
                Name = "Rollos de Canela", 
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "rollos.jfif", 
                Description = "Rollos de canela",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "450 gr harina sin polvos", IsCompleted = false},
                    new Ingredients {NameIngr = "2 1/4 cucharadita levadura seca (12 gramos aprox)", IsCompleted = false},
                    new Ingredients {NameIngr = "2 cucharadas agua tibia", IsCompleted = false},
                    new Ingredients {NameIngr = "250 ml leche tibia", IsCompleted = false},
                    new Ingredients {NameIngr = "100 gr azúcar blanca", IsCompleted = false},
                    new Ingredients {NameIngr = "1 huevo", IsCompleted = false},
                    new Ingredients {NameIngr = "Opcional: 1/2 cucharadita de esencia de vainilla", IsCompleted = false},
                    new Ingredients {NameIngr = "1/4 de cucharadita de sal", IsCompleted = false},
                    new Ingredients {NameIngr = "85 gramos de mantequilla sin sal", IsCompleted = false},
                    new Ingredients {NameIngr = "70 gramos de mantequilla", IsCompleted = false},
                    new Ingredients {NameIngr = "180 gramos azúcar rubia", IsCompleted = false},
                    new Ingredients {NameIngr = "3 cucharadas de canela molida", IsCompleted = false},
                    new Ingredients {NameIngr = "1 sobre de base para glaseado vainilla", IsCompleted = false},
                    new Ingredients {NameIngr = "1 cucharada de agua", IsCompleted = false}

                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "En un bowl poner la levadura, la leche tibia, agua tibia y mezclar. Luego, agregar el azúcar y mezclar bien. Agregar el huevo batido (con tenedor) y mezclar hasta integrar. Opcional: agregar 1/2 cucharadita de esencia de vainilla", IsCompleted = false},
                    new Steps {Description = "Agregar la mitad de la harina y mezclar con movimientos envolventes. Luego, agregar la mantequilla derretida y finalmente, la otra mitad de la harina y mezclar bien hasta formar una masa pegajosa pero que se puede despegar del bowl. Dejar reposar tapado por 1 1/2 hora, hasta que doble su volumen.", IsCompleted = false},
                    new Steps {Description = "Poner la masa en una superficie plana y hacer un rectángulo con uslero.", IsCompleted = false},
                    new Steps {Description = "Para el relleno, derretir la mantequilla y agregar azúcar morena y canela molida. Pincelear la masa con el relleno por toda la superficie. Después, enrollar la masa por el lado más largo y cortarlo en rollos de 1 ½ a 2 cm. aprox.", IsCompleted = false}, 
                    new Steps {Description = "Poner los rollos en una lata de horno o fuente enmantequillada dejando espacio entre cada uno. Dejar reposar por al menos 20 minutos o hasta que dupliquen su tamaño.", IsCompleted = false},
                    new Steps {Description = "Llevar a horno precalentado por 20 minutos a 180°C.", IsCompleted = false},
                    new Steps {Description = "Para el glaseado, mezclar todos los ingredientes y poner sobre los rollos calientes.", IsCompleted = false}

                },

            },
            //RECETA 9
            new Recipes 
            {
                Name = "Tacos de Carne", 
                ReadTime = new TimeSpan(0, 30, 0),
                ImageSource = "tacos.jfif", 
                Description = "Tacos de carne",

                Ingredientes = new ObservableCollection<Ingredients>
                {
                    new Ingredients {NameIngr = "(454 g.) 1 Libra Carne Molida De Res", IsCompleted = false},
                    new Ingredients {NameIngr = "Sal y Pimienta al gusto", IsCompleted = false},
                    new Ingredients {NameIngr = "(16 g.) 4 dientes Ajo Cortados finamente", IsCompleted = false},
                    new Ingredients {NameIngr = "(75 g.) 1/2 Taza Cebolla Cortada finamente", IsCompleted = false},
                    new Ingredients {NameIngr = "(5 ml.) 5 Cucharaditas Aceite De Maíz", IsCompleted = false},
                    new Ingredients {NameIngr = "(3 g.) 1 Cucharadita Paprika", IsCompleted = false},
                    new Ingredients {NameIngr = "(76 g.) 1 Sobre Crema De Tomate ", IsCompleted = false},
                    new Ingredients {NameIngr = "(500 ml.) 2 Tazas Agua", IsCompleted = false},
                    new Ingredients {NameIngr = "(370 g.) 2 Tazas Tomate Cortado en cubos pequeños", IsCompleted = false},
                    new Ingredients {NameIngr = "(90 g.) 3/4 Taza Cebolla Morada Cortada finamente", IsCompleted = false},
                    new Ingredients {NameIngr = "(65 ml.) 1/4 Taza Jugo de limón", IsCompleted = false},
                    new Ingredients {NameIngr = "(30 ml.) 2 Cucharadas Aceite De Oliva", IsCompleted = false},
                    new Ingredients {NameIngr = "(9 g.) 1/2 Taza Cilantro Cortado finamente", IsCompleted = false},
                    new Ingredients {NameIngr = "(480 g.) 16 Tortillas De Trigo", IsCompleted = false},
                    new Ingredients {NameIngr = "(172 g.) 1 1/2 Taza Queso Americano", IsCompleted = false}

                },
                Pasos = new ObservableCollection<Steps>
                {
                    new Steps {Description = "En un tazón, combinar la carne molida con sal, pimienta y dejar marinar 5 minutos.", IsCompleted = false},
                    new Steps {Description = "En una cacerola a fuego alto, verter el aceite y sofreír el ajo y la cebolla hasta que estén dorados.", IsCompleted = false},
                    new Steps {Description = "En una cacerola a fuego alto, verter el aceite y sofreír el ajo y la cebolla hasta que estén dorados.", IsCompleted = false},
                    new Steps {Description = "En otro tazón, diluir la Crema de Tomate en el agua. Verter esta mezcla en la cacerola junto a la carne, revolver y cocinar por 15 minutos. Retirar del fuego y reservar.", IsCompleted = false},
                    new Steps {Description = "En otro tazón, mezclar el tomate, la cebolla, el limón, el aceite, el cilantro, la sal, la pimienta y dejar marinar por 15 minutos en el refrigerador.", IsCompleted = false},
                    new Steps {Description = "En un sartén a fuego alto, calentar las tortillas por ambos lados.", IsCompleted = false},
                    new Steps {Description = "En cada tortilla, colocar 3 cucharadas de carne, 2 cucharadas de pico de gallo y 1 cucharada de Queso Americano", IsCompleted = false}
                },
            },
            };

            Carrousel.ItemsSource = Recetas;
            collection.ItemsSource = Recetas2;

        }

        //private void InitializeRecipes()
        //{

        //}
        public event PropertyChangedEventHandler PropertyChanged;

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            var item = button.BindingContext as Recipes;
            if (item != null)
            {
                await Navigation.PushAsync(new DetallesPage(item));
            }
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            var button1 = sender as ImageButton;
            var item = button1.BindingContext as Recipes;
            if (item != null)
            {
                await Navigation.PushAsync(new DetallesPage(item));
            }
        }

    }

}

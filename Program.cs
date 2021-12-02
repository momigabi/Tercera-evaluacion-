            int meses =0;		
		    string dato = "";
            int opcion = 0;
            int ActividadPerro = 0;
            int peso = 0;
            int edad = 0;
            
            do{
            //__________________________________________________________________
            Console.WriteLine("Bienvenid@ al programa, aqui te enseñaremos cuanto debe comer su mascota");


            Console.WriteLine("¿Tu perro es un cachorro o un adulto:");
            Console.WriteLine("1- Adulto");
            Console.WriteLine("2- Cachorro");
            dato = Console.ReadLine();
            edad = Convert.ToInt32(dato);

            switch (edad)
            {
             case 1: 
               Console.WriteLine("si su perro es un adulto...");
             break;


             case 2:
             Console.WriteLine("si su perro es un cachorro...");
             break;

            }

            if (edad == 1)
			{
//______________________________________________________________________________
            
			Console.WriteLine("¿Cual es el peso de su mascota (en kg)?");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);



                if (peso <= 5 && peso >=2)
                {
                    switch (ActividadPerro)
                {
                        case 1:
                            Console.WriteLine("Su perro miniatura debe comer entre 60 - 115 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro miniatura debe comer entre 55 y 100 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro miniatura debe comer entre 45 -85 gramos.");
                            break;
			    }
                }//_________________________

                if (peso <= 10 && peso >= 6)
                {
                switch (ActividadPerro)
                 {
                        case 1:
                            Console.WriteLine("Su perro pequeño debe comer entre 115 - 190 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro pequeño debe comer entre 100 - 170 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro pequeño debe comer entre 85 - 145 gramos.");
                            break;

                }
                }

                if (peso <= 15 && peso >= 11)
                {
                 switch (ActividadPerro)
                 {
                        case 1:
                            Console.WriteLine("Su perro medino debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro mediano debe comer entre 170 - 225 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro mediano debe comer entre 145 - 195 gramos.");
                            break;

                 }
                }
                if (peso <= 25 && peso >= 16) 
                {
                switch (ActividadPerro)
                {
                        case 1:
                            Console.WriteLine("Su perro grande debe comer entre 255-380 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro grande debe comer entre 225-330 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro grande debe comer entre 195-285 gramos.");
                            break;
                }
                }
                if (peso <= 40 && peso >= 26) 
                {
                switch (ActividadPerro)
                {
                        case 1:
                            Console.WriteLine("Su perro grande debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro grande debe comer entre 170 - 225 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro grande debe comer entre 145 - 195 gramos.");
                            break;
                }
                }
                if (peso <= 55 && peso >= 40)
                {
                 switch (ActividadPerro)
                 {
                        case 4:
                            Console.WriteLine("Su perro debe comer entre 145 - 195 gramos.");
                            break;
                        case 5:
                            Console.WriteLine("Su perro debe comer entre 145 - 195 gramos.");
                            break;
                }
                }
                if (peso <= 70 && peso >= 55) 
                {
                switch (ActividadPerro)
                {
                        case 1:
                            Console.WriteLine("Su perro grande debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro grande debe comer entre 170 - 225 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro grande debe comer entre 145 - 195 gramos.");
                            break;
                }
                }
                if (peso <= 90 && peso >= 71) 
                {
                 switch (ActividadPerro)
                {
                        case 1:
                            Console.WriteLine("Su perro grande debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro grande debe comer entre 170 - 225 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro grande debe comer entre 145 - 195 gramos.");
                            break;
             }
             }
            }	
				
//________________________________________________________________________________
            else 
    
            {
                
            
			Console.WriteLine("Indique el peso de su perro cachorro en KG");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                Console.WriteLine("indique cuantos mese tiene su cachorro:");
                Console.WriteLine("Opcion 1 - 2 meses");
                Console.WriteLine("Opcion 2 - 3 meses");
                Console.WriteLine("Opcion 3 - 4 meses");
				Console.WriteLine("Opcion 4 - 5 meses");
				Console.WriteLine("Opcion 5 - de 6 a 12 meses");
                dato = Console.ReadLine();
                meses = Convert.ToInt32(dato);

                if(peso == 2)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro miniatura debe comer 50 gr");
				break;
					case 2:
              Console.WriteLine("su perro miniatura debe comer 60 gr");
				break;
					case 3:
               Console.WriteLine("su perro miniatura debe comer 60 gr");
				break;
					case 4:
               Console.WriteLine("su perro miniatura debe comer 60 gr");
				break;
					case 5:
			   Console.WriteLine("su perro miniatura debe comer 55 gr");
		        break;
               }
               }
		        if(peso <= 10 && peso >= 5)
				{
                switch(meses)
				{
						case 1:
			   Console.WriteLine("su perro pequeño debe comer 95 - 155 gr gr");
				break;
					case 2:
              Console.WriteLine("su perro pequeño debe comer 110 - 185 gr");
				break;
					case 3:
               Console.WriteLine("su perro pequeño debe comer 115 - 195 gr");
				break;
					case 4:
               Console.WriteLine("su perr pequeño debe comer 115 - 190 gr");
				break;
					case 5:
			   Console.WriteLine("su perro pequeño debe comer 110 - 185 gr");
		        break;
               }
               }
                if(peso == 17)
				{
                switch(meses)
				{
						case 1:
			   Console.WriteLine("su perro mediano debe comer 215 gr");
				break;
					case 2:
              Console.WriteLine("su perro mediano debe comer 265 gr");
				break;
					case 3:
               Console.WriteLine("su perro mediano debe comer 285 gr");
				break;
					case 4:
               Console.WriteLine("su perro mediano debe comer 285 gr");
				break;
					case 5:
			   Console.WriteLine("su perro mediano debe comer 280 gr");
		        break;
               }
               }
		       if(peso <= 32 && peso >= 25)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro grande debe comer de 270 -300 gr");
				break;
					case 2:
              Console.WriteLine("su perro  grande debe de comer entre 350 - 400 gr");
				break;
					case 3:
               Console.WriteLine("su perro grande debe comer entre 375 - 450 gr");
				break;
					case 4:
               Console.WriteLine("su perro grande debe comer entre 375 a 450 gr");
				break;
					case 5:
				Console.WriteLine("su perro grande debe comer entre 370 - 450");
		        break;
               }
               }
			   if(peso == 40)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro grande debe comer de 355  gr");
				break;
					case 2:
              Console.WriteLine("su perro  grande debe de comer entre 475 gr");
				break;
					case 3:
               Console.WriteLine("su perro grande debe comer entre 525 gr");
				break;
					case 4:
               Console.WriteLine("su perro grande debe comer entre 530  gr");
				break;
                    case 5:
				Console.WriteLine("OPCION NO DISPONIBLE");
		        break;
					
               }
               }
                if(peso == 50)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro grande debe comer de 405  gr");
				break;
					case 2:
              Console.WriteLine("su perro  grande debe de comer entre 575 gr");
				break;
					case 3:
               Console.WriteLine("su perro grande debe comer entre 610 gr");
				break;
					case 4:
               Console.WriteLine("su perro grande debe comer entre 625  gr");
				break;
                     case 5:
				Console.WriteLine("OPCION NO DISPONIBLE");
		        break;
					
               }
               }
			    if(peso == 60)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro grande debe comer de 450  gr");
				break;
					case 2:
              Console.WriteLine("su perro  grande debe de comer entre 605 gr");
				break;
					case 3:
               Console.WriteLine("su perro grande debe comer entre 685 gr");
				break;
                    case 4:
               Console.WriteLine("OPCION NO DISPONIBLE");
				break;
                    case 5:
				Console.WriteLine("OPCION NO DISPONIBLE");
		        break;
					
					
               }
               }
			    if(peso == 70)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro grande debe comer de 485  gr");
				break;
					case 2:
              Console.WriteLine("su perro  grande debe de comer entre 670 gr");
				break;
                     case 3:
               Console.WriteLine("OPCION NO DISPONIBLE");
				break;
					case 4:
               Console.WriteLine("OPCION NO DISPONIBLE");
				break;
                    case 5:
				Console.WriteLine("OPCION NO DISPONIBLE");
		        break;
					
               }
               }
			 if(peso == 90)
				{
                switch(meses)
				{
					case 1:
			   Console.WriteLine("su perro grande debe comer de 580  gr");
				break;
                    case 2:
              Console.WriteLine("OPCION NO DISPONIBLE");
				break;
					case 3:
               Console.WriteLine("OPCION NO DISPONIBLE");
				break;
					case 4:
               Console.WriteLine("OPCION NO DISPONIBLE");
				break;
                    case 5:
				Console.WriteLine("OPCION NO DISPONIBLE");
		        break;
					
					
               }
               }
       }  

       Console.WriteLine("Si desea continuar escriba 1, si desea salir del programa escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
 //_____________________________________________________________________________   

                            
               
          }while(opcion != 4);


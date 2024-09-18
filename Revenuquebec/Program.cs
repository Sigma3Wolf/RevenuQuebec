internal class Program {
    private static void Main(string[] args) {
        //Question #1
        string strName = "";
        while (strName.Length == 0) {
            Console.WriteLine("Entrez votre nom:");
            strName = (Console.ReadLine() + "").Trim();
        }

        //Question #2
        float sngDeductionSexe = 0;
        string strSexe = "";
        while (strSexe.Length == 0) {
            Console.WriteLine("Sélectionner votre sexe ([M]/[F]/[N]bin/fl[U]i/[A]utre): ");
            ConsoleKeyInfo objAnswer = Console.ReadKey();
            string strAnswer = objAnswer.KeyChar.ToString().ToUpper();
            switch (strAnswer) {
                case "M":
                    strSexe = strAnswer;
                    sngDeductionSexe = 10f / 100;
                    break;

                case "F":
                    strSexe = strAnswer;
                    sngDeductionSexe = 20f / 100;
                    break;

                case "N":
                    strSexe = strAnswer;
                    sngDeductionSexe = 15f / 100;
                    break;

                case "U":
                    strSexe = strAnswer;
                    sngDeductionSexe = 15f / 100;
                    break;

                case "A":
                    strSexe = strAnswer;
                    sngDeductionSexe = 10f / 100;
                    break;
            }
        }

        //Question #3
        bool blnSuccess = false;
        string strSalaire = "";
        int lngSalaire = 0;
        while ((strSalaire.Length == 0) || (blnSuccess = false)) {
            Console.WriteLine("\nEntrez votre salaire annuel:");
            strSalaire = (Console.ReadLine() + "").Trim();
            blnSuccess = int.TryParse(strSalaire, out lngSalaire);

            if (blnSuccess) {
                if (lngSalaire < 0) {
                    Console.WriteLine("Salaire invalide, doit être plus grand que 0");
                    blnSuccess = false;
                }
            }
        }

        //Question #4
        string strWed = "";
        int lngMarital = 0;
        while (strWed.Length == 0) {
            Console.WriteLine("Êtes-vous marié ([O]/[N]/[A]utre): ");
            ConsoleKeyInfo objAnswer = Console.ReadKey();
            string strAnswer = objAnswer.KeyChar.ToString().ToUpper();
            switch (strAnswer) {
                case "O":
                    lngMarital = 1;
                    strWed = strAnswer;
                    break;

                case "N":
                    lngMarital = 2;
                    strWed = strAnswer;
                    break;

                case "A":
                    lngMarital = 3;
                    strWed = strAnswer;
                    break;
            }
        }

        //Question #5
        blnSuccess = false;
        string strEnfant = "";
        int lngEnfant = 0;
        while ((strEnfant.Length == 0) || (blnSuccess = false)) {
            Console.WriteLine("\nCombien d'enfants vous avez: ");
            strEnfant = (Console.ReadLine() + "").Trim();
            blnSuccess = int.TryParse(strEnfant, out lngEnfant);
            if (blnSuccess) {
                if (lngEnfant < 0) {
                    Console.WriteLine("Entrez au moins 0\n");
                    blnSuccess = false;
                }
            }
        }

        float sngDeductionP = 0;
        if (lngMarital == 1) {
            //O
            sngDeductionP = 20f / 100;  // 20/100 = 0    20f/100 = 0.2
        } else if (lngMarital == 2) {
            //N
            sngDeductionP = 30f / 100;
        } else {
            //A
            sngDeductionP = 14f / 100;
        }

        float sngDeduction1 = (lngSalaire) * sngDeductionP;
        sngDeduction1 = (float)Math.Round(sngDeduction1, 0);
        float sngDeduction2 = lngEnfant * 5000;
        
        float sngDeduction3 = (lngSalaire) * sngDeductionSexe;
        sngDeduction3 = (float)Math.Round(sngDeduction3, 0);
        float sngTotalDecution = sngDeduction1 + sngDeduction2 + sngDeduction3;
        float lngSalaireFinal = lngSalaire - sngTotalDecution;

        //Fin du programme
        Console.WriteLine("\nMerci");

        if (strSexe == "M") {
            Console.WriteLine("M. " + strName);
        } else if (strSexe == "F") {
            Console.WriteLine("Mme " + strName);
        } else {
            Console.WriteLine("M. ou Mme " + strName);
        }

        Console.WriteLine("Voici le calcul de vos déductions");
        Console.WriteLine("Salaire          " + lngSalaire.ToString());

        Console.WriteLine("\nDéduction Base   " + sngDeduction1.ToString());
        Console.WriteLine("Déduction Sexe   " + sngDeduction3.ToString());
        Console.WriteLine("Déduction Enfant " + sngDeduction2.ToString());
        Console.WriteLine("                 -------------------");
        Console.WriteLine("Déduction Total  " + sngTotalDecution.ToString());
        
        Console.WriteLine("                 ===================");
        Console.WriteLine("Revenu final     " + lngSalaireFinal.ToString());
        Console.WriteLine("\n\n\n\n");
    }
}
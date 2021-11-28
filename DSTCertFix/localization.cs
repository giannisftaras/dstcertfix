using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTCertFix
{
    internal class localization
    {

        private readonly Dictionary<string, string> el_GR = new Dictionary<string, string> {
            { "browserOpenMessage", "Παρακαλούμε κλείστε όλους τους περιηγητές σας (Google Chrome, Mozilla Firefox, κλπ.) πρωτού προχωρήσετε με την επιδιόρθωση." },
            { "browserOpenTitle", "Ανιχνεύθηκε ανοιχτός περιηγητής" },
            { "currentUserRadio", "Μόνο για μένα" },
            { "englishToolStrip", "Αγγλικά" },
            { "errorDialogTitle", "Σφάλμα" },
            { "errorMainMessage", "Υπήρξε σφάλμα κατά τη προσπάθεια εφαρμογής της διόρθωσης." },
            { "errorMessageStr", "Μήνυμα: " },
            { "errorType", "Τύπος: " },
            { "FixSumbit", "Διόρθωση" },
            { "formTitle", "Διόρθωση Πιστοποιητικού DST" },
            { "greekToolStrip", "Ελληνικά" },
            { "groupBoxTitle", "Επιλέξτε τον λογαριασμό χρήστη που θα θέλατε να διορθώσετε:" },
            { "helpStripLink", "Βοήθεια" },
            { "languageSelectTooltip", "Επιλογή γλώσσας" },
            { "localMachineRadio", "Για όλους τους χρήστες αυτού του υπολογιστή" },
            { "noSelectDialogTitle", "Προειδοποίηση" },
            { "noSelectMessage", "Παρακαλούμε κάντε μία επιλογή πριν εφαρμόσετε τη διόρθωση." },
            { "successDialogTitle", "Επιτυχής επιδιόρθωση" },
            { "successLocalMessage", "Η διόρθωση εφαρμόστηκε επιτυχώς για τον λογαριασμό σας!" },
            { "successMachineMessage", "Η διόρθωση εφαρμόστηκε επιτυχώς για όλους τους χρήστες του υπολογιστή!" },
            { "uacDialogTitle", "Διαχειριστική Πρόσβαση" },
            { "uacInfoDialog", "Για την αλλαγή του πιστοποιητικού σε όλους τους χρήστες αυτού του υπολογιστή πρέπει να παρέχετε δικαιώματα διαχειριστή σε αυτή την εφαρμογή." },
            { "uacInfoDialogTitle", "Πληροφορίες" },
            { "uacMessage", "Πρέπει να παρέχετε δικαιώματα διαχειριστή σε αυτή την εφαρμογή για να εφαρμοστεί η διόρθωση σε όλους τους χρήστες αυτού του υπολογιστή. Εναλλακτικά μπορείτε να εφαρμόσετε τη διόρθωση μόνο για τον δικό σας λογαριασμό χρήστη, που δεν απαιτεί δικαιώματα διαχειριστή." }
        };

        private readonly Dictionary<string, string> en_US = new Dictionary<string, string> {
            { "browserOpenMessage", "Please close all your browsers (Google Chrome, Mozilla Firefox, etc.) before running the fix." },
            { "browserOpenTitle", "Detected open browser" },
            { "currentUserRadio", "For me only" },
            { "englishToolStrip", "English" },
            { "errorDialogTitle", "Error" },
            { "errorMainMessage", "There was an error while trying to apply the fix." },
            { "errorMessageStr", "Message: " },
            { "errorType", "Type: " },
            { "FixSumbit", "Fix" },
            { "formTitle", "DTS Certificate Fix" },
            { "greekToolStrip", "Greek" },
            { "groupBoxTitle", "Select the user account you would like to fix:" },
            { "helpStripLink", "Help" },
            { "languageSelectTooltip", "Select language" },
            { "localMachineRadio", "For all users in this computer" },
            { "noSelectDialogTitle", "Warning" },
            { "noSelectMessage", "Please make a selection before applying the fix." },
            { "successDialogTitle", "Successful fix" },
            { "successLocalMessage", "The fix was applied successfully for your user account!" },
            { "successMachineMessage", "The fix was applied successfully for all users in this computer!" },
            { "uacDialogTitle", "Administrative Access" },
            { "uacInfoDialog", "To change the certificate for all the users in this computer you need to provide administrative prvillages to the application." },
            { "uacInfoDialogTitle", "Information" },
            { "uacMessage", "You need to provide administrative privillages to the application in order to apply the fix to all users in this computer. Alternatively you can apply the fix just to your user account, which does not require administrative access." }
        };

        public string Get_string(String lang, String str)
        {
            if (lang == "el")
            {
                if (el_GR.ContainsKey(str))
                {
                    return el_GR[str];
                }
            } else if (lang == "en")
            {
                if (en_US.ContainsKey(str))
                {
                    return en_US[str];
                }
            }
            return "";
        }

    }
}

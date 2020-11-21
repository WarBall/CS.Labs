USING SYSTEM;
USING SYSTEM.IO;

NAMESPACE CS.LABS7.TASK3
{
    PUBLIC CLASS COPYFILEUPPER
    {
        STATIC VOID MAIN()
        {
            STRING SFROM, STO;
            STREAMREADER SRFORM;//ССЫЛКА НА ВХОДНОЙ ФАЙЛ
            STREAMWRITER SWTO;//ССЫЛКА НА ВЫХОДНОЙ ФАЙЛ

            CONSOLE.WRITELINE("COPY FROM: ");
            SFROM = CONSOLE.READLINE();

            CONSOLE.WRITELINE("COPY TO: ");
            STO = CONSOLE.READLINE();

            CONSOLE.WRITELINE("COPY FROM {0} TO {1}", SFROM, STO);

            TRY
            {
                USING (SRFORM = NEW STREAMREADER(SFROM))
                USING (SWTO = NEW STREAMWRITER(STO))
                {

                    WHILE (SRFORM.PEEK() != -1)
                    {
                        STRING SBUFFER = SRFORM.READLINE();
                        SBUFFER = SBUFFER.TOUPPER();
                        SWTO.WRITELINE(SBUFFER);
                    }
                }
            }
            CATCH (FILENOTFOUNDEXCEPTION)
            {
                CONSOLE.WRITELINE("INPUT FILE NOT FOUND");
            }
            CATCH (EXCEPTION EX)
            {
                CONSOLE.WRITELINE("UNEXPECTED EXCEPTION");
                CONSOLE.WRITELINE(EX.TOSTRING());
            }
        }
    }
}

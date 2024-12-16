using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
class ConfigBackup
{
    //Retornando Configuração do arquivo INI
    public string CurrentConfigINI(string session,string index)
    {
        var File = new FileIniDataParser();
        IniData content = File.ReadFile(this.IniFile());
        var result = content[session][index];
        return result;
    }

    //Mudando Configuração no Arquivo INI
    public void ModifyConfigIni(string session, string index,string value)
    {
        var File = new FileIniDataParser();
        IniData content = File.ReadFile(this.IniFile());
        content[session][index] = value;
        File.WriteFile(this.IniFile(), content);
    }

    //Inicia as Configurações de BKP Default
    public void ConfBackupDefault()
    {
       this.IniConfigurationDefault();
        
    }

    //Retorna o Caminho do Arquivo INI
    private string IniFile()
    {
        var CaminhoSystema = System.AppDomain.CurrentDomain.BaseDirectory;
        var CaminhoFileIni = ConfigurationManager.AppSettings["DefaultPathIni"];
        var CaminhoConhecidoAPP = ConfigurationManager.AppSettings["DefaultPathExe"];
        if (CaminhoSystema == null) { CaminhoFileIni = ""; }
        if (CaminhoFileIni == null) {CaminhoFileIni = "";}
        if (CaminhoConhecidoAPP == null) { CaminhoConhecidoAPP = ""; }
        var FileINI = CaminhoSystema.Replace(CaminhoConhecidoAPP,"");
        return FileINI+CaminhoFileIni;
    }


    //Retorna a Pasta Padrão de Backup
    public string DefaultPathBKP()
    {
        var CaminhoSystema = System.AppDomain.CurrentDomain.BaseDirectory;
        var CaminhoConhecidoAPP = ConfigurationManager.AppSettings["DefaultPathExe"];
        var CaminhoPastaDefault = ConfigurationManager.AppSettings["DefaultPathBkp"];

        var PastaBKP = CaminhoSystema.Replace(CaminhoConhecidoAPP, "");

        return PastaBKP + CaminhoPastaDefault;
    }


    //Configurando o BACKUP DEFAULT no Arquivo INI
    private void IniConfigurationDefault()
    {
        var File = new FileIniDataParser();
        IniData content = File.ReadFile(this.IniFile());
        content["BKP_CONFIG_DEFAULT"]["DEFAULT_PATH"] = this.DefaultPathBKP();
        content["BKP_CONFIG_DEFAULT"]["TYPE_BKP"] = "TOTAL";
        File.WriteFile(this.IniFile(), content);

    }

    //Iniciando configuração Personalizada


    // CONFIGURAÇÃO PERSONALIZADA
    public void SaveConfigurationPerson(string Path)
    {
        this.ConfBkpPerson(Path);
    }
   
    private void ConfBkpPerson(string Path)
    {
        string Session = "BKP_CONFIG_PERSON";
        string index = "PATH";
        string value = Path;
        this.ModifyConfigIni(Session,index,value);
    }
    

    //Gravar diretórios para backup
    public void SaveDirectories(List<string> Directories)
    {
        var Arquivo = this.ListaDiretorios();
        var PastaBKP = Arquivo.Replace(@"\Directories.txt", "");
        
        if (Directory.Exists(PastaBKP))
        {
            if (File.Exists(Arquivo))
            {
                MessageBox.Show(this.ListaDiretorios());
            }
            else
            {
                File.Create(PastaBKP + @"\Directories.txt").Dispose();
            }
        }
        else
        {
            Directory.CreateDirectory(PastaBKP);
        }
    
    }

    private string ListaDiretorios()
    {
        var CaminhoSystema = System.AppDomain.CurrentDomain.BaseDirectory;
        var ArquivoLista = ConfigurationManager.AppSettings["DirectoryDir"];
        var CaminhoConhecidoAPP = ConfigurationManager.AppSettings["DefaultPathExe"];
        var CaminhoPadrãoLista = CaminhoSystema.Replace(CaminhoConhecidoAPP, "");
        return CaminhoPadrãoLista + ArquivoLista;
    }
}

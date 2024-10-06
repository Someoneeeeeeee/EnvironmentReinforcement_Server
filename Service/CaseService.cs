using Server.Modal;

namespace Server.Service
{
    public class CaseService
    {
        public CaseService() { }
        public Case[] GetAllCase() { return new Case[0]; }
        public Case GetCase(int id) { return new Case(); }
        public void Create(Case caseObj) { return; }
    }
}

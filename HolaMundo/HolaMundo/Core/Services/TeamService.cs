using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo.Core.Services
{
    public class TeamService
    {
        private List<Team> teams;

        public TeamService()
        {
            LoadTeams();
        }

        private void LoadTeams()
        {
            teams = new List<Team>();
            teams.Add(new Team
            {
                Id = 1,
                Name = "Deportivo Pasto",
                Location = "Pasto",
                ShieldUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Deportivo_Pasto_logo.png",
                BornYear = 1949
            });
            teams.Add(new Team
            {
                Id = 2,
                Name = "Millonarios",
                Location = "Bogota",
                ShieldUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Escudo_de_Millonarios_temporada_2017.png/584px-Escudo_de_Millonarios_temporada_2017.png",
                BornYear = 1946
            });
        }
        public List<Team> GetTeams()
        {
            return teams;
        }

        public Team GetTeamById(int id)
        {
            return teams.Find(x => x.Id == id);
        }
    }
}

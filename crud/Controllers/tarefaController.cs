using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using crud.Models;


namespace crud.Controllers
{
    //Criando a classe tarefaController e herdando seus métodos de Controller
    public class tarefaController : Controller
    {
        //Criando um objeto _tarefas que armanazerá uma lista de tareas
        private static List<tarefa>_tarefas = new List<tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }
        //Criando método para carregar a tela de Adicionar
        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(tarefa novaTarefa)
        {
            //Verificando o totla de tarefas da lista e somando mais um para o ID
            novaTarefa.Id = _tarefas.Count + 1;
            //Adicionando minha nova tarefa à minha lista
            _tarefas.Add(novaTarefa);
            //Redirecionar para a página com a lista de tarefas
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int Id)
        {
            //Estou buscando na minha lista a tarefa que desejo alterar
            tarefa tarefaBD = _tarefas.FirstOrDefault(tarefaBD => tarefaBD.Id == Id);
            //Verificando se encontrou a tarefa, se ela não é null
            if(tarefaBD == null)
            return NotFound();
            //Enviando para a View a tarefa encontrada que queremos alterar
            return View(tarefaBD);
        }
        [HttpPost]
        public IActionResult Editar(tarefa tarefaEditando)
        {
            //Buscando tarefa na lista
            tarefa tarefaDB = _tarefas.Find(tarefaController => tarefaController.Id == tarefaEditando.Id);
            //Verificando se encontrou ela
            if(tarefaDB == null)
            return NotFound();

            //Atualizando os dados da tarefa que já está na lista
            tarefaDB.Descricao = tarefaEditando.Descricao;
            tarefaDB.Concluida = tarefaEditando.Concluida;
            //Redirecionando para a lista de tarefas
            return RedirectToAction("Index");
        }
    public IActionResult Deletar(int Id)
        {
            //Estou buscando na minha lista a tarefa que desejo alterar
            tarefa tarefaBD = _tarefas.FirstOrDefault(tarefaBD => tarefaBD.Id == Id);
            //Verificando se encontrou a tarefa, se ela não é null
            if(tarefaBD == null)
            return NotFound();
            //Enviando para a View a tarefa encontrada que queremos alterar
            return View(tarefaBD);
        }
        [HttpPost]
        public IActionResult Deletar(tarefa tarefaExcluida)
        {
            //Buscando tarefa na lista
            tarefa tarefaDB = _tarefas.Find(tarefaController => tarefaController.Id == tarefaExcluida.Id);
            //Verificando se encontrou ela
            if(tarefaDB == null)
            return NotFound();

            _tarefas.Remove(tarefaDB);

            return RedirectToAction("Index");
        }
    }

}
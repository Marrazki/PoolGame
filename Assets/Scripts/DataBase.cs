using UnityEngine;

[CreateAssetMenu(fileName = "BaseDatos", menuName = "Inventario/Lista", order = 1)]
public class DataBase : ScriptableObject
{
    [System.Serializable]
    public struct ObjetoInventario
    {
        public string nombre;
        public int ID;
        public Sprite icono;
        public Tipo tipo;
        public string descripcion;
        public string Void;
    }

    public enum Tipo
    { 
        diamante,
        tiza
    }

    public ObjetoInventario[] baseDatos;
}

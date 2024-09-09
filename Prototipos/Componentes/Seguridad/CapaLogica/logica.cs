﻿using System;
using System.Data;
using CapaDatos;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaLogica
{
    public class logica
    {

        sentencia sn;

        public logica(string idUsuario)
        {
            sn = new sentencia(idUsuario);
        }



        public DataTable consultaLogicaUsuarios()
        {
            
            try
            {
                OdbcDataAdapter dtUsuario = sn.consultarUsuarios();
                DataTable tableUsuario = new DataTable();
                dtUsuario.Fill(tableUsuario);
                return tableUsuario;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            
        }

        public DataTable consultaLogicaModulos()
        {
            try
            {
                OdbcDataAdapter dtModulos = sn.consultarModulos();
                DataTable tableModulos = new DataTable();
                dtModulos.Fill(tableModulos);
                return tableModulos;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaPerfiles()
        {
            try
            {
                OdbcDataAdapter dtPerfiles = sn.consultarPerfiles();
                DataTable tablePerfiles = new DataTable();
                dtPerfiles.Fill(tablePerfiles);
                return tablePerfiles;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable consultaLogicaAplicaciones(string ID_aplicacion)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.consultaraplicaciones(ID_aplicacion))
                {
                    DataTable tableAplicaciones = new DataTable();
                    cmpsAplicaciones.Fill(tableAplicaciones);
                    return tableAplicaciones;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################

        public DataTable consultaLogicaPermisosUsuarioAplicacion(string codigoUsuario, string nombreAplicacion, string ingresar, string consulta, string modificar, string eliminar, string imprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosUA = sn.insertarPermisosUA(codigoUsuario, nombreAplicacion, ingresar, consulta, modificar, eliminar, imprimir);
                DataTable tablePermisosUA = new DataTable();
                dtPermisosUA.Fill(tablePermisosUA);
                return tablePermisosUA;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaPerfilesUsuarios(string nombreUsuario)
        {
            try
            {
                OdbcDataAdapter dtPerfilesUsuarios = sn.mostrarPerfilesDeUsuario(nombreUsuario);
                DataTable tablePerfilesUsuarios = new DataTable();
                dtPerfilesUsuarios.Fill(tablePerfilesUsuarios);
                return tablePerfilesUsuarios;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaEliminarPerfilUsuario(string nombreUsuario, string codigoPerfil)
        {
            try
            {
                OdbcDataAdapter dtEliminarPerfilUsuario = sn.eliminarPerfilUsuario(nombreUsuario, codigoPerfil);
                DataTable tableEliminarPerfilUsuario = new DataTable();
                dtEliminarPerfilUsuario.Fill(tableEliminarPerfilUsuario);
                return tableEliminarPerfilUsuario;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable consultaLogicaInsertarPerfilUsuario(string nombreUsuario, string codigoPerfil)
        {
            try
            {
                OdbcDataAdapter dtInsertarPerfilUsuario = sn.insertarPerfilUsuario(nombreUsuario, codigoPerfil);
                DataTable tableInsertarPerfilUsuario = new DataTable();
                dtInsertarPerfilUsuario.Fill(tableInsertarPerfilUsuario);
                return tableInsertarPerfilUsuario;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public DataTable validarIDAplicacion()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.validarIDAplicacion();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
        public DataTable ActualizarUsuario(string idUsuario, string nombreUsuario, string apellidoUsuario,string clave, string estado)
        {
            try
            {
                OdbcDataAdapter dtactualizarUsuario = sn.ActualizarUsuario(idUsuario, nombreUsuario, apellidoUsuario,clave, estado);
                DataTable tableUsuariosActualizacion = new DataTable();
                dtactualizarUsuario.Fill(tableUsuariosActualizacion);
                return tableUsuariosActualizacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }



        /* creado por Emerzon Garcia  0901-21-9182 ...... */

        public bool Eliminarperfil(string ID_perfil)
        {
            try
            {
                bool result = sn.EliminarPerfil1(ID_perfil);
                if (result)
                {
                    MessageBox.Show("Perfil eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el perfil.");
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }


        public DataTable usuarios(string id, string nombre, string apellido, string clave, int boton)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.insertarusuario(id, nombre, apellido, clave, boton);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable clave(string id, string nombre, string apellido, string clave)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.insertarclaves(id, nombre, apellido, clave);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable updateclave(string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.update(usuario);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable updatecliente(string clave,string usuario)
        {
            try
            {
                OdbcDataAdapter dtusuario = sn.clienteupdate(clave,usuario);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                return tableusuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        //###################  lo que hizo Karla  Sofia Gómez Tobar #######################
        public bool insertaraplicaciones(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {

                sn.insertaraplicacion(codigo, nombre, descripcion, estado);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el aplicacion: " + ex.Message);
                return false;
            }
        }
        //###################  termina lo que hizo  Karla  Sofia Gómez Tobar #######################
        public DataTable eliminar(string id, string nombre, string apellido, string clave)
        {
            try
            {
                OdbcDataAdapter dteliminar = sn.eliminarusuario(id, nombre, apellido, clave);
                DataTable tableliminar = new DataTable();
                dteliminar.Fill(tableliminar);
                return tableliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Esta parte fue echa por Carlos Hernandez
        public DataTable modificaraplicaciones(string idaplicacion, string descripcion, string aplicacion)
        {
            try
            {
                OdbcDataAdapter dtModificar = sn.modificaraplicaciones(idaplicacion, descripcion, aplicacion);
                DataTable tableModificar = new DataTable();
                dtModificar.Fill(tableModificar);
                return tableModificar;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar la aplicación: {ex.Message}");
                return null;
            }
        }
        //termina lo que hizo carlos hernandez 

        public DataTable eliminaraplicaciones(string idaplicacion, string descripcion, string aplicacion)
        {
            try
            {
                OdbcDataAdapter dteliminar = sn.eliminaraplicacion(idaplicacion, descripcion, aplicacion);
                DataTable tableliminar = new DataTable();
                dteliminar.Fill(tableliminar);
                return tableliminar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable buscar(string id)
        {
            try
            {

                OdbcDataAdapter dtusuario = sn.mostrar(id);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                if (tableusuarios == null)
                    return null;
                else
                    return tableusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable buscaraplicacion(string id)
        {
            try
            {

                OdbcDataAdapter dtusuario = sn.mostraraplicacion(id);
                DataTable tableusuarios = new DataTable();
                dtusuario.Fill(tableusuarios);
                if (tableusuarios == null)
                    return null;
                else
                    return tableusuarios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable validarIDModulos()
        {
            try
            {
                OdbcDataAdapter dtValidarIDModulo = sn.validarIDModulos();
                DataTable tableValidacionIdModulo = new DataTable();
                dtValidarIDModulo.Fill(tableValidacionIdModulo);
                return tableValidacionIdModulo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        // termina

        public DataTable validarIDperfiles()
        {
            try
            {
                OdbcDataAdapter dtValidarIDAplicacion = sn.validarIDperfiles();
                DataTable tableValidacionIdAplicacion = new DataTable();
                dtValidarIDAplicacion.Fill(tableValidacionIdAplicacion);
                return tableValidacionIdAplicacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable ingresarperfiles(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter ingresoperfil = sn.insertarPerfil(codigo, nombre, descripcion, estado);
                DataTable tableperfiles = new DataTable();
                ingresoperfil.Fill(tableperfiles);
                return tableperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public DataTable ConsultaLogicaPerfil(string ID_perfil)
        {
            try
            {
                OdbcDataAdapter cmpsperfiles = sn.ConsultarPerfil(ID_perfil);
                DataTable tablaperfiles = new DataTable();
                cmpsperfiles.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }


        public DataTable Actualizarperfil(string ID_perfil, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtperfil = sn.ActualizarPerfil(ID_perfil, nombre, descripcion, estado);
                DataTable tablaperfiles = new DataTable();
                dtperfil.Fill(tablaperfiles);
                return tablaperfiles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }


        }


        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public bool ingresarmodulos(string codigo, string nombre, string descripcion, string estado)
        {
            try
            {
                // Ejecutar la inserción
                sn.insertarModulo(codigo, nombre, descripcion, estado);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar el módulo: " + ex.Message);
                return false;
            }
        } // termina



        public DataTable consultaLogicaPermisosPerfilAplicacion(string codigoPerfil, string nombreAplicacion, string ingresar, string consulta, string modificar, string eliminar, string imprimir)
        {
            try
            {
                OdbcDataAdapter dtPermisosPerfilA = sn.insertarPermisosPerfilA(codigoPerfil, nombreAplicacion, ingresar, consulta, modificar, eliminar, imprimir);
                DataTable tablePermisosPerfilA = new DataTable();
                dtPermisosPerfilA.Fill(tablePermisosPerfilA);
                return tablePermisosPerfilA;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Trabajado por María José Véliz Ochoa, 9959-21-5909
        public DataTable ConsultaLogicaModulo(string ID_modulo)
        {
            try
            {
                using (OdbcDataAdapter cmpsModulos = sn.ConsultarModulos(ID_modulo))
                {
                    DataTable tablaModulos = new DataTable();
                    cmpsModulos.Fill(tablaModulos);
                    return tablaModulos;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return null;
            }
        }
        // termina




        public DataTable Actualizarmodulo(string ID_modulo,string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.ActualizarModulo(ID_modulo,nombre,descripcion,estado);
                DataTable tablamodulos = new DataTable();
                dtmodulo.Fill(tablamodulos);
                return tablamodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }

            
        }

        public DataSet consultaLogicaBitacora()
        {
            return sn.consultarBitacora();
        }

        //ELIMINAR MODULO ALYSON ##########################################
        public DataTable EliminarModulo(string ID_modulo, string nombre, string descripcion, string estado)
        {
            try
            {
                OdbcDataAdapter dtmodulo = sn.EliminarModulo(ID_modulo, nombre, descripcion, estado);
                DataTable tablamodulos = new DataTable();
                dtmodulo.Fill(tablamodulos);
                return tablamodulos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        //FIN ####################################################################





    }

}

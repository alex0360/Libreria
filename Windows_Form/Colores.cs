using System.Drawing;

namespace Libreria.Colores
{
    public class Colores// Link de referencia: https://www.cerotec.net/tabla-colores-web/
    {        
        #region Rojos
        /// <summary>Rojo Puro</summary>
        public static Color Red {get { return new Color(255, 0, 0); }}
        /// <summary>Rojo Fuego</summary>
        public static Color FireBrick {get { return new Color(178, 34, 34); }}
        /// <summary>Rojo Oscuro</summary>
        public static Color DarkRed {get {return new Color(139, 0, 0);}}
        /// <summary>Rojo Indio</summary>
        public static Color IndianRed {get {return new Color(205, 92, 205);}}
        /// <summary>Carmesí</summary>
        public static Color Crimson {get {return new Color(220, 20, 60);}}
        /// <summary>Coral Suave</summary>
        public static Color LightCoral {get {return new Color(240, 128, 128);}}
        /// <summary>Salmón</summary>
        public static Color Salmon {get {return new Color(250, 128, 114);}}
        /// <summary>Salmón Suave</summary>
        public static Color LightSalmon {get {return new Color(255, 160, 122);}}
        /// <summary>Salmón oscuro</summary>
        public static Color DarkSalmon {get {return new Color(240, 128, 128);}}
        #endregion
        #region Rosas
        /// <summary>Rosa</summary>
        public static Color Pink {get { return new Color(255, 192, 203); }}
        /// <summary>Rosa Suave</summary>
        public static Color LightPink {get { return new Color(255, 182, 193); }}
        /// <summary>Rosa Cálido</summary>
        public static Color HotPink {get { return new Color(255, 105, 180); }}
        /// <summary>Rosa Profundo</summary>
        public static Color DeepPink {get { return new Color(255, 20, 147); }}
        /// <summary>Medio Violeta Rojo</summary>
        public static Color MediumVioletRed {get { return new Color(199, 21, 133); }}
        /// <summary>Rosa Pastel</summary>
        public static Color PaleVioletRed {get { return new Color(219, 112, 147); }}
        #endregion
        #region Naranjas
        /// <summary>Naranja Puro</summary>
        public static Color Orange {get { return new Color(255, 165, 0); }}
        /// <summary> Naranja Rojizo</summary>
        public static Color OrangeRed { get { return new Color(255, 69, 0); }}
        /// <summary>Naranja Oscuro</summary>
        public static Color DarkOrange {get { return new Color(255, 140, 0); }}
        /// <summary>Naranja Coral</summary>
        public static Color Coral {get { return new Color(255, 127, 80); }}
        /// <summary>Tomate</summary>
        public static Color Tomato {get { return new Color(255, 99, 71); }}
        #endregion
        #region Amarillos
        /// <summary>Amarillo Oro</summary>
        public static Color Gold {get { return new Color(255, 215, 0); }}
        /// <summary>Amarillo Puro</summary>
        public static Color Yellow {get { return new Color(255, 255, 0); }}
        /// <summary>Amarillo Suave</summary>
        public static Color LightYellow {get { return new Color(255, 255, 224); }}
        /// <summary>Amarillo Limón</summary>
        public static Color LemonChiffon {get { return new Color(255, 250, 205); }}
        /// <summary>Amarillo Manzana Suave</summary>
        public static Color LightGoldenrodYellow {get { return new Color(250, 250, 210); }}
        /// <summary>Amarillo Papaya</summary>
        public static Color PapayaWhip {get { return new Color(255, 239, 213); }}
        /// <summary>Amarillo Mocasín</summary>
        public static Color Moccasin {get { return new Color(255, 228, 181); }}
        /// <summary>Amarillo Melocotón</summary>
        public static Color PeachPuff {get { return new Color(255, 218, 185); }}
        /// <summary>Amarillo Oro Pálido</summary>
        public static Color PaleGoldenrod {get { return new Color(238, 232, 170); }}
        /// <summary>Amarillo Caqui</summary>
        public static Color Khaki {get { return new Color(240, 230, 140); }}
        /// <summary>Amarillo Caqui Oscuro</summary>
        public static Color DarkKhaki {get { return new Color(189, 183, 107); }}
        #endregion
        #region Púrpuras
        /// <summary>Espliego</summary>
        public static Color Lavender {get { return new Color(230, 230, 250); }}//#E6E6FA
        /// <summary>Cardo</summary>
        public static Color Thistle {get { return new Color(216, 191, 216); }}//#D8BFD8
        /// <summary>Ciruela</summary>
        public static Color Plum {get { return new Color(221, 160, 221); }}//#DDA0DD
        /// <summary>Violeta</summary>
        public static Color Violet {get { return new Color(238, 130, 238); }}//#EE82EE
        /// <summary>Orquídea</summary>
        public static Color Orchid {get { return new Color(218, 112, 214); }}//#DA70D6
        /// <summary>Fucsia</summary>
        public static Color Fuchsia {get { return new Color(255, 0, 254); }}//#FF00FE
        /// <summary>Magenta</summary>
        public static Color Magenta {get { return new Color(255, 0, 255); }}//#FF00FF
        /// <summary>Orquídea Medio</summary>
        public static Color MediumOrchid {get { return new Color(186, 85, 211); }}//#BA55D3
        /// <summary>Púrpura Medio</summary>
        public static Color MediumPurple {get { return new Color(147, 112, 219); }}//#9370DB
        /// <summary>Amatista</summary>
        public static Color Amethyst {get { return new Color(153, 102, 204); }}//#9966CC
        /// <summary>Azul Violeta</summary>
        public static Color BlueViolet {get { return new Color(138, 43, 226); }}//#8A2BE2
        /// <summary>Violeta Oscuro</summary>
        public static Color DarkViolet {get { return new Color(148, 0, 211); }}//#9400D3
         /// <summary>Orquídea Oscuro</summary>
        public static Color DarkOrchid {get { return new Color(153, 50, 204); }}//#9932CC
         /// <summary>Magenta Oscuro</summary>
        public static Color DarkMagenta {get { return new Color(139, 0, 139); }}//#8B008B
         /// <summary>Púrpura</summary>
        public static Color Purple {get { return new Color(128, 0, 128); }}//#800080
         /// <summary>Índigo</summary>
        public static Color Indigo {get { return new Color(75, 0, 130); }}//#4B0082
         /// <summary>Azul Pizarra</summary>
        public static Color SlateBlue {get { return new Color(106, 90, 205); }}//#6A5ACD
         /// <summary>Azul Pizarra Oscuro</summary>
        public static Color DarkSlateBlue {get { return new Color(72, 61, 139); }}//#483D8B
        #endregion
        #region Verdes
        /// <summary>Verde Amarillento</summary>
        public static Color GreenYellow {get { return new Color(173, 255, 47); }}//#ADFF2F
         /// <summary>Verde Cartujano</summary>
        public static Color Chartreuse {get { return new Color(127, 255, 0); }}//#7FFF00
         /// <summary>Verde Césped</summary>
        public static Color LawnGreen {get { return new Color(124, 253, 0); }}//#7CFC00
         /// <summary>Lima</summary>
        public static Color Lime {get { return new Color(0, 255, 0); }}//#00FF00
         /// <summary>Verde Lima</summary>
        public static Color LimeGreen { get { return new Color(50, 205, 50); } }//#32CD32
         /// <summary>Verde Pálido</summary>
        public static Color PaleGreen {get { return new Color(152, 251, 152); }}//#98FB98
         /// <summary> Verde Claro</summary>
        public static Color LightGreen {get { return new Color(144, 238, 144); }}//#90EE90
         /// <summary>Verde Primavera Medio</summary>
        public static Color MediumSpringGreen {get { return new Color(0, 250, 154); }}//#00FA9A
         /// <summary>Verde Primavera</summary>
        public static Color SpringGreen {get { return new Color(0, 255, 127); }}//#00FF7F
         /// <summary>Verde Mar Medio</summary>
        public static Color MediumSeaGreen {get { return new Color(60, 179, 113); }}//#3CB371
         /// <summary>Verde Mar</summary>
        public static Color SeaGreen {get { return new Color(46, 139, 87); }}//#2E8B57
         /// <summary>Verde Bosque</summary>
        public static Color ForestGreen {get { return new Color(34, 139, 34); }}//#228B22
         /// <summary>Verde</summary>
        public static Color Green {get { return new Color(0, 128, 0); }}//#008000
         /// <summary>Verde Oscuro</summary>
        public static Color DarkGreen {get { return new Color(0, 100, 0); }}//#006400
         /// <summary>Amarillo Verdoso</summary>
        public static Color YellowGreen {get { return new Color(154, 205, 50); }}//#9ACD32
         /// <summary>Verde Oliva</summary>
        public static Color OliveDrab {get { return new Color(107, 142, 35); }}//#6B8E23
         /// <summary>Oliva</summary>
        public static Color Olive {get { return new Color(128, 128, 0); }}//#808000
         /// <summary>Verde Oliva Oscuro</summary>
        public static Color DarkOliveGreen {get { return new Color(85, 107, 47); }}//#556B2F
         /// <summary>Aguamarina Medio</summary>
        public static Color MediumAquamarine {get { return new Color(102, 205, 170); }}//#66CDAA
         /// <summary>Verde Mar Oscuro</summary>
        public static Color DarkSeaGreen {get { return new Color(143, 188, 143); }}//#8FBC8F
         /// <summary>Verde Mar Claro</summary>
        public static Color LightSeaGreen {get { return new Color(32, 178, 170); }}//#20B2AA
         /// <summary>Cyan Oscuro</summary>
        public static Color DarkCyan {get { return new Color(0, 139, 139); }}//#008B8B
         /// <summary>Carcel</summary>
        public static Color Teal {get { return new Color(0, 128, 128); }}//#008080
        #endregion
        #region Azules
        /// <summary>Azul</summary>
        public static Color Blue { get { return new Color(0, 0, 255); } }//#0000FF
        /// <summary>Agua</summary>
        public static Color Aqua {get { return new Color(0, 255, 254); }}//#00FFE0
         /// <summary>Cyan </summary>
        public static Color Cyan {get { return new Color(0, 255, 255); }}//#00FFFF
         /// <summary>Cyan Suave</summary>
        public static Color LightCyan {get { return new Color(224, 255, 255); }}//#E0FFFF
         /// <summary>Turquesa Pastel</summary>
        public static Color PaleTurquoise {get { return new Color(175, 238, 238); }}//#AFEEEE
         /// <summary>Aguamarina</summary>
        public static Color Aquamarine {get { return new Color(127, 255, 212); }}//#7FFFD4
         /// <summary>Turquesa</summary>
        public static Color Turquoise {get { return new Color(64, 224, 208); }}//#40E0D0
         /// <summary>Turquesa Medio</summary>
        public static Color MediumTurquoise {get { return new Color(72, 209, 204); }}//#48D1CC
         /// <summary>Turquesa Oscuro</summary>
        public static Color DarkTurquoise {get { return new Color(0, 206, 209); }}//#00CED1
         /// <summary>Azul Cadete</summary>
        public static Color CadetBlue {get { return new Color(95, 158, 160); }}//#5F9EA0
         /// <summary>Azul Acero</summary>
        public static Color SteelBlue {get { return new Color(70, 130, 180); }}//#4682B4
         /// <summary>Azul Acero Claro</summary>
        public static Color LightSteelBlue {get { return new Color(176, 196, 222); }}//#B0C4DE
         /// <summary>Azul Pálido</summary>
        public static Color PowderBlue {get { return new Color(176, 224, 230); }}//#B0E0E6
         /// <summary>Azul Claro</summary>
        public static Color LightBlue {get { return new Color(173, 216, 230); }}//#ADD8E6
         /// <summary>Azul Cielo</summary>
        public static Color SkyBlue {get { return new Color(135, 206, 235); }}//#87CEEB
         /// <summary>Azul Cielo Claro</summary>
        public static Color LightSkyBlue {get { return new Color(135, 206, 250); }}//#87CEFA
         /// <summary>Azul Cielo Profundo</summary>
        public static Color DeepSkyBlue {get { return new Color(0, 191, 255); }}//#00BFFF
         /// <summary>Azul Capota</summary>
        public static Color DodgerBlue {get { return new Color(30, 144, 255); }}//#1E90FF
         /// <summary>Azul Añil</summary>
        public static Color CornflowerBlue {get { return new Color(100, 149, 237); }}//#6495ED
         /// <summary>Azul Pizarra Medio</summary>
        public static Color MediumSlateBlue {get { return new Color(123, 104, 238); }}//#7B68EE
        /// <summary>Azul Real</summary>
        public static Color RoyalBlue {get { return new Color(65, 105, 255); }}//#4169E1
         /// <summary>Azul Medio</summary>
        public static Color MediumBlue {get { return new Color(0, 0, 205); }}//#0000CD
         /// <summary>Azul Oscuro</summary>
        public static Color DarkBlue {get { return new Color(0, 0, 139); }}//#00008B
         /// <summary> Azul Naval</summary>
        public static Color Navy {get { return new Color(0, 0, 128); }}//#000080
         /// <summary>Azul Media Noche</summary>
        public static Color MidnightBlue {get { return new Color(25, 25, 112); }}//#191970
        #endregion
        #region Marrones
        /// <summary>Marrón</summary>
        public static Color Brown { get { return new Color(165, 42, 42); } }//#A52A2A
        /// <summary>Seda de Maiz</summary>
        public static Color Cornsilk { get { return new Color(255, 248, 220); } }//#FFF8DC
        /// <summary>Almendra</summary>
        public static Color BlanchedAlmondn { get { return new Color(255, 235, 205); } }//#FFEBCD
        /// <summary>Bizcocho</summary>
        public static Color Bisque { get { return new Color(255, 228, 196); } }//#FFE4C4
        /// <summary>Marrón Navaja</summary>
        public static Color NavajoWhite { get { return new Color(255, 222, 173); } }//#FFDEAD
        /// <summary>Marrón Trigo</summary>
        public static Color Wheat { get { return new Color(245, 222, 179); } }//#F5DEB3
        /// <summary>Madera Fuerte</summary>
        public static Color BurlyWood { get { return new Color(222, 184, 135); } }//#DEB887
        /// <summary>Marrón bronceado</summary>
        public static Color Tan { get { return new Color(210, 180, 140); } }//#D2B48C
        /// <summary>Marrón Atractivo</summary>
        public static Color RosyBrown { get { return new Color(188, 143, 143); } }//##BC8F8F
        /// <summary>Marrón Arenoso</summary>
        public static Color SandyBrown { get { return new Color(224, 164, 96); } }//#F4A460
        /// <summary>Vara de Oro</summary>
        public static Color Goldenrod { get { return new Color(218, 165, 32); } }//#DAA520
        /// <summary>Vara de Oro Oscura</summary>
        public static Color DarkGoldenrod { get { return new Color(184, 134, 11); } }//#B8860B
        /// <summary>Marrón Perú</summary>
        public static Color Peru { get { return new Color(205, 133, 63); } }//#CD853F
        /// <summary>Marrón Chocolate</summary>
        public static Color Chocolate { get { return new Color(210, 105, 30); } }//#D2691E
        /// <summary>Marrón Silla</summary>
        public static Color SaddleBrown { get { return new Color(139, 69, 19); } }//#8B4513
        /// <summary>Marrón Siena</summary>
        public static Color Sienna { get { return new Color(160, 82, 45); } }//#A0522D
        /// <summary>Castaño</summary>
        public static Color Maroon { get { return new Color(128, 0, 0); } }//#800000
        #endregion
        #region Blancos
        /// <summary>Blanco</summary>
        public static Color White { get { return new Color(255, 255, 255); } }//#FFFFFF
        /// <summary>Blanco Nieve</summary>
        public static Color Snow { get { return new Color(255, 250, 250); } }//#FFFAFA
        /// <summary>Miel Crema</summary>
        public static Color Honeydew { get { return new Color(240, 255, 240); } }//#F0FFF0
        /// <summary>Menta Crema</summary>
        public static Color MintCream { get { return new Color(245, 255, 250); } }//#F5FFFA
         /// <summary>Azul Celeste</summary>
        public static Color Azure { get { return new Color(240, 255, 255); } }//#F0FFFF
        /// <summary>Azul Alicia</summary>
        public static Color AliceBlue { get { return new Color(240, 248, 2550); } }//#F0F8FF
        /// <summary>Blanco Fantasma</summary>
        public static Color GhostWhite { get { return new Color(248, 248, 255); } }//#F8F8FF
        /// <summary>Blanco Humo</summary>
        public static Color WhiteSmoke { get { return new Color(245, 245, 245); } }//#F5F5F5
        /// <summary>Concha de Mar</summary>
        public static Color Seashell { get { return new Color(255, 245, 238); } }//#FFF5EE
        /// <summary>Beige</summary>
        public static Color Beige { get { return new Color(245, 245, 220); } }//#F5F5DC
        /// <summary>Blanco Cordón Viejo</summary>
        public static Color OldLace { get { return new Color(253, 245, 230); } }//#FDF5E6
        /// <summary>Blanco Floral</summary>
        public static Color FloralWhite { get { return new Color(255, 250, 240); } }//#FFFAF0
        /// <summary>Blanco Marfil</summary>
        public static Color Ivory { get { return new Color(255, 255, 240); } }//#FFFFF0
        /// <summary>Blanco Antigüo</summary>
        public static Color AntiqueWhite { get { return new Color(250, 235, 215); } }//#FAEBD7
        /// <summary>Blanco Lino</summary>
        public static Color Linen { get { return new Color(250, 240, 230); } }//#FAF0E6
        /// <summary>Lavanda</summary>
        public static Color LavenderBlush { get { return new Color(255, 240, 245); } }//#FFF0F5
        /// <summary>Rosa Palo</summary>
        public static Color MistyRose { get { return new Color(255, 228, 225); } }//#FFE4E1
        #endregion
        #region Grises
        /// <summary>Gainsboro</summary>
        public static Color Gainsboro { get { return new Color(220, 220, 220); } }//#DCDCDC
        /// <summary>Gris Claro</summary>
        public static Color LightGrey { get { return new Color(211, 211, 211); } }//#D3D3D3
        /// <summary>Gris Plata</summary>
        public static Color Silver { get { return new Color(192, 192, 192); } }//#C0C0C0
        /// <summary>Gris Oscuro</summary>
        public static Color DarkGray { get { return new Color(169, 169, 169); } }//#A9A9A9
        /// <summary>Gris</summary>
        public static Color Gray { get { return new Color(128, 128, 128); } }//#808080
        /// <summary>Gris Ténue</summary>
        public static Color DimGray { get { return new Color(105, 105, 105); } }//#696969
        /// <summary>Gris Pizarra Claro</summary>
        public static Color LightSlateGray { get { return new Color(119, 136, 153); } }//#778899
        /// <summary>Gris Pizarra</summary>
        public static Color SlateGray { get { return new Color(112, 128, 144); } }//#708090
        /// <summary>Gris Pizarra Oscuro</summary>
        public static Color DarkSlateGray { get { return new Color(47, 79, 79); } }//#2F4F4F
        /// <summary>Negro</summary>
        public static Color Black { get { return new Color(0, 0, 0); } }//#000000
        #endregion
    }
}
extern alias System_Runtime_Extensions;
namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write3_FNRH(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"FNRH", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write2_FNRH(@"FNRH", namespace1, ((global::SNRHos.FNRH)o), true, false, namespace1, @"");
        }

        void Write2_FNRH(string n, string ns, global::SNRHos.FNRH o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::SNRHos.FNRH)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"FNRH", defaultNamespace);
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snnumcpf", namespace2, ((global::System.String)o.@Snnumcpf));
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sntipdoc", namespace3, ((global::System.String)o.@Sntipdoc));
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snnumdoc", namespace4, ((global::System.String)o.@Snnumdoc));
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snorgexp", namespace5, ((global::System.String)o.@Snorgexp));
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snnomecompleto", namespace6, ((global::System.String)o.@Snnomecompleto));
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snemail", namespace7, ((global::System.String)o.@Snemail));
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snocupacao", namespace8, ((global::System.String)o.@Snocupacao));
            string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snnacionalidade", namespace9, ((global::System.String)o.@Snnacionalidade));
            string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Sndtnascimento", namespace10, FromDateTime(((global::System.DateTime)o.@Sndtnascimento)));
            string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snsexo", namespace11, ((global::System.String)o.@Snsexo));
            string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sncelularddd", namespace12, ((global::System.String)o.@Sncelularddd));
            string namespace13 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sncelularddi", namespace13, ((global::System.String)o.@Sncelularddi));
            string namespace14 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sncelularnum", namespace14, ((global::System.String)o.@Sncelularnum));
            string namespace15 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sntelefoneddd", namespace15, ((global::System.String)o.@Sntelefoneddd));
            string namespace16 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sntelefoneddi", namespace16, ((global::System.String)o.@Sntelefoneddi));
            string namespace17 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sntelefonenum", namespace17, ((global::System.String)o.@Sntelefonenum));
            string namespace18 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snresidencia", namespace18, ((global::System.String)o.@Snresidencia));
            string namespace19 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snpaisres", namespace19, ((global::System.String)o.@Snpaisres));
            string namespace20 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snestadores", namespace20, ((global::System.String)o.@Snestadores));
            string namespace21 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sncidaderes", namespace21, ((global::System.String)o.@Sncidaderes));
            string namespace22 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdscpais", namespace22, ((global::System.String)o.@Bgstdscpais));
            string namespace23 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdscpaisdest", namespace23, ((global::System.String)o.@Bgstdscpaisdest));
            string namespace24 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdscestado", namespace24, ((global::System.String)o.@Bgstdscestado));
            string namespace25 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdscestadodest", namespace25, ((global::System.String)o.@Bgstdscestadodest));
            string namespace26 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdsccidade", namespace26, ((global::System.String)o.@Bgstdsccidade));
            string namespace27 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdsccidadedest", namespace27, ((global::System.String)o.@Bgstdsccidadedest));
            string namespace28 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdsccidade2", namespace28, ((global::System.String)o.@Bgstdsccidade2));
            string namespace29 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Bgstdsccidadedest2", namespace29, ((global::System.String)o.@Bgstdsccidadedest2));
            string namespace30 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snmotvia", namespace30, ((global::System.String)o.@Snmotvia));
            string namespace31 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Sntiptran", namespace31, ((global::System.String)o.@Sntiptran));
            string namespace32 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Snprevent", namespace32, FromDateTime(((global::System.DateTime)o.@Snprevent)));
            string namespace33 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Snprevsai", namespace33, FromDateTime(((global::System.DateTime)o.@Snprevsai)));
            string namespace34 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snobs", namespace34, ((global::System.String)o.@Snobs));
            string namespace35 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snnumhosp", namespace35, ((global::System.String)o.@Snnumhosp));
            string namespace36 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Snuhnum", namespace36, ((global::System.String)o.@Snuhnum));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read3_FNRH(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_FNRH && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read2_FNRH(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":FNRH");
            }
            return (object)o;
        }

        global::SNRHos.FNRH Read2_FNRH(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_FNRH && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::SNRHos.FNRH o;
            o = new global::SNRHos.FNRH();
            bool[] paramsRead = new bool[35];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id3_Snnumcpf && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snnumcpf = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id4_Sntipdoc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sntipdoc = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id5_Snnumdoc && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snnumdoc = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id6_Snorgexp && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snorgexp = Reader.ReadElementContentAsString();
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id7_Snnomecompleto && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snnomecompleto = Reader.ReadElementContentAsString();
                        }
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id8_Snemail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snemail = Reader.ReadElementContentAsString();
                        }
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id9_Snocupacao && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snocupacao = Reader.ReadElementContentAsString();
                        }
                        paramsRead[6] = true;
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id10_Snnacionalidade && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snnacionalidade = Reader.ReadElementContentAsString();
                        }
                        paramsRead[7] = true;
                    }
                    else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id11_Sndtnascimento && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sndtnascimento = ToDateTime(Reader.ReadElementContentAsString());
                        }
                        paramsRead[8] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id12_Snsexo && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snsexo = Reader.ReadElementContentAsString();
                        }
                        paramsRead[9] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id13_Sncelularddd && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sncelularddd = Reader.ReadElementContentAsString();
                        }
                        paramsRead[10] = true;
                    }
                    else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id14_Sncelularddi && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sncelularddi = Reader.ReadElementContentAsString();
                        }
                        paramsRead[11] = true;
                    }
                    else if (!paramsRead[12] && ((object) Reader.LocalName == (object)id15_Sncelularnum && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sncelularnum = Reader.ReadElementContentAsString();
                        }
                        paramsRead[12] = true;
                    }
                    else if (!paramsRead[13] && ((object) Reader.LocalName == (object)id16_Sntelefoneddd && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sntelefoneddd = Reader.ReadElementContentAsString();
                        }
                        paramsRead[13] = true;
                    }
                    else if (!paramsRead[14] && ((object) Reader.LocalName == (object)id17_Sntelefoneddi && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sntelefoneddi = Reader.ReadElementContentAsString();
                        }
                        paramsRead[14] = true;
                    }
                    else if (!paramsRead[15] && ((object) Reader.LocalName == (object)id18_Sntelefonenum && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sntelefonenum = Reader.ReadElementContentAsString();
                        }
                        paramsRead[15] = true;
                    }
                    else if (!paramsRead[16] && ((object) Reader.LocalName == (object)id19_Snresidencia && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snresidencia = Reader.ReadElementContentAsString();
                        }
                        paramsRead[16] = true;
                    }
                    else if (!paramsRead[17] && ((object) Reader.LocalName == (object)id20_Snpaisres && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snpaisres = Reader.ReadElementContentAsString();
                        }
                        paramsRead[17] = true;
                    }
                    else if (!paramsRead[18] && ((object) Reader.LocalName == (object)id21_Snestadores && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snestadores = Reader.ReadElementContentAsString();
                        }
                        paramsRead[18] = true;
                    }
                    else if (!paramsRead[19] && ((object) Reader.LocalName == (object)id22_Sncidaderes && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sncidaderes = Reader.ReadElementContentAsString();
                        }
                        paramsRead[19] = true;
                    }
                    else if (!paramsRead[20] && ((object) Reader.LocalName == (object)id23_Bgstdscpais && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdscpais = Reader.ReadElementContentAsString();
                        }
                        paramsRead[20] = true;
                    }
                    else if (!paramsRead[21] && ((object) Reader.LocalName == (object)id24_Bgstdscpaisdest && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdscpaisdest = Reader.ReadElementContentAsString();
                        }
                        paramsRead[21] = true;
                    }
                    else if (!paramsRead[22] && ((object) Reader.LocalName == (object)id25_Bgstdscestado && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdscestado = Reader.ReadElementContentAsString();
                        }
                        paramsRead[22] = true;
                    }
                    else if (!paramsRead[23] && ((object) Reader.LocalName == (object)id26_Bgstdscestadodest && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdscestadodest = Reader.ReadElementContentAsString();
                        }
                        paramsRead[23] = true;
                    }
                    else if (!paramsRead[24] && ((object) Reader.LocalName == (object)id27_Bgstdsccidade && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdsccidade = Reader.ReadElementContentAsString();
                        }
                        paramsRead[24] = true;
                    }
                    else if (!paramsRead[25] && ((object) Reader.LocalName == (object)id28_Bgstdsccidadedest && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdsccidadedest = Reader.ReadElementContentAsString();
                        }
                        paramsRead[25] = true;
                    }
                    else if (!paramsRead[26] && ((object) Reader.LocalName == (object)id29_Bgstdsccidade2 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdsccidade2 = Reader.ReadElementContentAsString();
                        }
                        paramsRead[26] = true;
                    }
                    else if (!paramsRead[27] && ((object) Reader.LocalName == (object)id30_Bgstdsccidadedest2 && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Bgstdsccidadedest2 = Reader.ReadElementContentAsString();
                        }
                        paramsRead[27] = true;
                    }
                    else if (!paramsRead[28] && ((object) Reader.LocalName == (object)id31_Snmotvia && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snmotvia = Reader.ReadElementContentAsString();
                        }
                        paramsRead[28] = true;
                    }
                    else if (!paramsRead[29] && ((object) Reader.LocalName == (object)id32_Sntiptran && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Sntiptran = Reader.ReadElementContentAsString();
                        }
                        paramsRead[29] = true;
                    }
                    else if (!paramsRead[30] && ((object) Reader.LocalName == (object)id33_Snprevent && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snprevent = ToDateTime(Reader.ReadElementContentAsString());
                        }
                        paramsRead[30] = true;
                    }
                    else if (!paramsRead[31] && ((object) Reader.LocalName == (object)id34_Snprevsai && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snprevsai = ToDateTime(Reader.ReadElementContentAsString());
                        }
                        paramsRead[31] = true;
                    }
                    else if (!paramsRead[32] && ((object) Reader.LocalName == (object)id35_Snobs && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snobs = Reader.ReadElementContentAsString();
                        }
                        paramsRead[32] = true;
                    }
                    else if (!paramsRead[33] && ((object) Reader.LocalName == (object)id36_Snnumhosp && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snnumhosp = Reader.ReadElementContentAsString();
                        }
                        paramsRead[33] = true;
                    }
                    else if (!paramsRead[34] && ((object) Reader.LocalName == (object)id37_Snuhnum && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Snuhnum = Reader.ReadElementContentAsString();
                        }
                        paramsRead[34] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Snnumcpf, :Sntipdoc, :Snnumdoc, :Snorgexp, :Snnomecompleto, :Snemail, :Snocupacao, :Snnacionalidade, :Sndtnascimento, :Snsexo, :Sncelularddd, :Sncelularddi, :Sncelularnum, :Sntelefoneddd, :Sntelefoneddi, :Sntelefonenum, :Snresidencia, :Snpaisres, :Snestadores, :Sncidaderes, :Bgstdscpais, :Bgstdscpaisdest, :Bgstdscestado, :Bgstdscestadodest, :Bgstdsccidade, :Bgstdsccidadedest, :Bgstdsccidade2, :Bgstdsccidadedest2, :Snmotvia, :Sntiptran, :Snprevent, :Snprevsai, :Snobs, :Snnumhosp, :Snuhnum");
                    }
                }
                else {
                    UnknownNode((object)o, @":Snnumcpf, :Sntipdoc, :Snnumdoc, :Snorgexp, :Snnomecompleto, :Snemail, :Snocupacao, :Snnacionalidade, :Sndtnascimento, :Snsexo, :Sncelularddd, :Sncelularddi, :Sncelularnum, :Sntelefoneddd, :Sntelefoneddi, :Sntelefonenum, :Snresidencia, :Snpaisres, :Snestadores, :Sncidaderes, :Bgstdscpais, :Bgstdscpaisdest, :Bgstdscestado, :Bgstdscestadodest, :Bgstdsccidade, :Bgstdsccidadedest, :Bgstdsccidade2, :Bgstdsccidadedest2, :Snmotvia, :Sntiptran, :Snprevent, :Snprevsai, :Snobs, :Snnumhosp, :Snuhnum");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id36_Snnumhosp;
        string id28_Bgstdsccidadedest;
        string id4_Sntipdoc;
        string id27_Bgstdsccidade;
        string id19_Snresidencia;
        string id21_Snestadores;
        string id35_Snobs;
        string id12_Snsexo;
        string id10_Snnacionalidade;
        string id11_Sndtnascimento;
        string id14_Sncelularddi;
        string id3_Snnumcpf;
        string id9_Snocupacao;
        string id24_Bgstdscpaisdest;
        string id33_Snprevent;
        string id8_Snemail;
        string id2_Item;
        string id29_Bgstdsccidade2;
        string id7_Snnomecompleto;
        string id37_Snuhnum;
        string id30_Bgstdsccidadedest2;
        string id25_Bgstdscestado;
        string id6_Snorgexp;
        string id32_Sntiptran;
        string id17_Sntelefoneddi;
        string id13_Sncelularddd;
        string id23_Bgstdscpais;
        string id34_Snprevsai;
        string id31_Snmotvia;
        string id1_FNRH;
        string id16_Sntelefoneddd;
        string id15_Sncelularnum;
        string id20_Snpaisres;
        string id22_Sncidaderes;
        string id26_Bgstdscestadodest;
        string id18_Sntelefonenum;
        string id5_Snnumdoc;

        protected override void InitIDs() {
            id36_Snnumhosp = Reader.NameTable.Add(@"Snnumhosp");
            id28_Bgstdsccidadedest = Reader.NameTable.Add(@"Bgstdsccidadedest");
            id4_Sntipdoc = Reader.NameTable.Add(@"Sntipdoc");
            id27_Bgstdsccidade = Reader.NameTable.Add(@"Bgstdsccidade");
            id19_Snresidencia = Reader.NameTable.Add(@"Snresidencia");
            id21_Snestadores = Reader.NameTable.Add(@"Snestadores");
            id35_Snobs = Reader.NameTable.Add(@"Snobs");
            id12_Snsexo = Reader.NameTable.Add(@"Snsexo");
            id10_Snnacionalidade = Reader.NameTable.Add(@"Snnacionalidade");
            id11_Sndtnascimento = Reader.NameTable.Add(@"Sndtnascimento");
            id14_Sncelularddi = Reader.NameTable.Add(@"Sncelularddi");
            id3_Snnumcpf = Reader.NameTable.Add(@"Snnumcpf");
            id9_Snocupacao = Reader.NameTable.Add(@"Snocupacao");
            id24_Bgstdscpaisdest = Reader.NameTable.Add(@"Bgstdscpaisdest");
            id33_Snprevent = Reader.NameTable.Add(@"Snprevent");
            id8_Snemail = Reader.NameTable.Add(@"Snemail");
            id2_Item = Reader.NameTable.Add(@"");
            id29_Bgstdsccidade2 = Reader.NameTable.Add(@"Bgstdsccidade2");
            id7_Snnomecompleto = Reader.NameTable.Add(@"Snnomecompleto");
            id37_Snuhnum = Reader.NameTable.Add(@"Snuhnum");
            id30_Bgstdsccidadedest2 = Reader.NameTable.Add(@"Bgstdsccidadedest2");
            id25_Bgstdscestado = Reader.NameTable.Add(@"Bgstdscestado");
            id6_Snorgexp = Reader.NameTable.Add(@"Snorgexp");
            id32_Sntiptran = Reader.NameTable.Add(@"Sntiptran");
            id17_Sntelefoneddi = Reader.NameTable.Add(@"Sntelefoneddi");
            id13_Sncelularddd = Reader.NameTable.Add(@"Sncelularddd");
            id23_Bgstdscpais = Reader.NameTable.Add(@"Bgstdscpais");
            id34_Snprevsai = Reader.NameTable.Add(@"Snprevsai");
            id31_Snmotvia = Reader.NameTable.Add(@"Snmotvia");
            id1_FNRH = Reader.NameTable.Add(@"FNRH");
            id16_Sntelefoneddd = Reader.NameTable.Add(@"Sntelefoneddd");
            id15_Sncelularnum = Reader.NameTable.Add(@"Sncelularnum");
            id20_Snpaisres = Reader.NameTable.Add(@"Snpaisres");
            id22_Sncidaderes = Reader.NameTable.Add(@"Sncidaderes");
            id26_Bgstdscestadodest = Reader.NameTable.Add(@"Bgstdscestadodest");
            id18_Sntelefonenum = Reader.NameTable.Add(@"Sntelefonenum");
            id5_Snnumdoc = Reader.NameTable.Add(@"Snnumdoc");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class FNRHSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"FNRH", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write3_FNRH(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read3_FNRH(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System_Runtime_Extensions::System.Collections.Hashtable readMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"SNRHos.FNRH::"] = @"Read3_FNRH";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable writeMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"SNRHos.FNRH::"] = @"Write3_FNRH";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable typedSerializers = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp.Add(@"SNRHos.FNRH::", new FNRHSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::SNRHos.FNRH)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::SNRHos.FNRH)) return new FNRHSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}

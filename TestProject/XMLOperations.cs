using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SimpleReaderTools.Core.Utilities;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace TestProject
{
    [TestClass]
    public class XMLOperations
    {
        [TestMethod]
        public void GetXmlStringTest()
        {
            string xml = GetXml();

            var str = SimpleReaderTools.Core.Utilities.XMLOperations.GetXmlString(xml, true);
            var str1 = SimpleReaderTools.Core.Utilities.XMLOperations.GetXmlString(xml, false);
        }

        [TestMethod]
        public void SortXmlNodesTest()
        {
            string xml = GetXml();
            var str = SimpleReaderTools.Core.Utilities.XMLOperations.GetOrderedNodesXmlString(xml, true);
            var str1 = SimpleReaderTools.Core.Utilities.XMLOperations.GetXmlString(xml, true);
            var str2 = SimpleReaderTools.Core.Utilities.XMLOperations.GetOrderedNodesXmlString(xml, false);
        }

        [TestMethod]
        public void JsToXml()
        {
            var json = "{aobj:{aa:1,bb:3},nc:32}";
            var jObj = Newtonsoft.Json.Linq.JObject.Parse(json);
            var xml = JsonConvert.DeserializeXmlNode(json,"root");
            var xmlString = GetXmlFormatString(xml, true);
            var jsString = JsonConvert.SerializeXmlNode(xml);
        }

        public static string GetXmlFormatString(XmlDocument doc, bool isFormat)
        {
            string result = "";

            XmlWriterSettings wSets = new XmlWriterSettings();
            wSets.Encoding = Encoding.UTF8;
            wSets.OmitXmlDeclaration = true;
            wSets.Indent = isFormat;

            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                using (var writer = XmlTextWriter.Create(sw, wSets))
                {
                    doc.Save(writer);
                    writer.Flush();
                    sw.Flush();
                    result = sw.ToString();
                }
            }
            return result;
        }

        private string GetXml()
        {
            return 
                @"
                    <ICSMXML xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns=""http://www.icsm.com/icsmxml"">
                      <Header>
                        <MsgDelivery>
                          <To>
                            <Credential>
                              <Domain>ICSMID</Domain>
                              <Identity>28</Identity>
                            </Credential>
                          </To>
                          <From>
                            <Credential>
                              <Domain>ICSMID</Domain>
                              <Identity>BOSSAPITEST</Identity>
                            </Credential>
                          </From>
                          <Sender>
                            <Credential>
                              <Domain>DNS</Domain>
                              <Identity>BOSSAPI</Identity>
                            </Credential>
                          </Sender>
                        </MsgDelivery>
                        <MsgHeader>
                          <MessageId>2b6a529d-4b7b-40d6-9bbe-e8988ed83e46</MessageId>
                          <Timestamp>5/18/2021 6:56:32 PM</Timestamp>
                          <DocumentId>ICSMPO</DocumentId>
                        </MsgHeader>
                        <ConversationState>
                          <ConversationId>5e042a6f-f8db-4a39-9e74-426f6809178f</ConversationId>
                        </ConversationState>
                      </Header>
                      <Request deploymentMode=""test"">
                        <OrderRequest>
                          <OrderRequestHeader orderDate=""2021-05-11"" orderID=""123456"" type=""new"" orderType=""release"" shippingType=""item"">
                            <CustomerIdentification>
                              <CustomerInfo name=""PONumber"">123456</CustomerInfo>
                              <CorporateInfo name=""AccountNumber"">ANY</CorporateInfo>
                            </CustomerIdentification>
                          </OrderRequestHeader>
                          <LineItem sequence=""1"">
                            <CustomerIdentification>
                              <CorporateInfo name=""ConfigId"">a4923287-96d6-4c63-913f-788109be5d4c</CorporateInfo>
                              <CorporateInfo name=""ConfigEngine"">navINK</CorporateInfo>
                              <CorporateInfo name=""unitOfMeasureQty"">1</CorporateInfo>
                              <CorporateInfo name=""unitTransferCost"">0.000000</CorporateInfo>
                              <CorporateInfo name=""SellCode"">E</CorporateInfo>
                            </CustomerIdentification>
                            <LineItemShipping carrier=""P"" serviceLevel=""PF"">
                              <ShipTo>
                                <Address>
                                  <Name />
                                  <PostalAddress addressID="""">
                                    <DeliverTo>Jane Doe</DeliverTo>
                                    <Street>3678 Ne So St</Street>
                                    <Street />
                                    <City>Renton</City>
                                    <State>WA</State>
                                    <PostalCode>98032</PostalCode>
                                    <Country>US</Country>
                                  </PostalAddress>
                                </Address>
                              </ShipTo>
                            </LineItemShipping>
                            <PartnerItemDetail type=""point"" lineNumber=""1001"" quantity=""1"" unitOfMeasure=""EA"">
                              <Item id=""1857"" />
                              <Price valueType=""unit"">
                                <Money currency=""USD"">0.000000</Money>
                              </Price>
                              <Price valueType=""extended"">
                                <Money currency=""USD"">0.00</Money>
                              </Price>
                            </PartnerItemDetail>
                            <PartnerItemDetail type=""production"" lineNumber=""1001"" quantity=""1"" unitOfMeasure=""EA"">
                              <Item id=""1857"" />
                              <Price valueType=""unit"">
                                <Money currency=""USD"">0.000000</Money>
                              </Price>
                              <Price valueType=""extended"">
                                <Money currency=""USD"">0.00</Money>
                              </Price>
                            </PartnerItemDetail>
                          </LineItem>
                          <LineItem sequence=""2"" subSequence=""1"">
                            <CustomerIdentification>
                              <CorporateInfo name=""ConfigId"">87393490-2ee5-4b73-b791-871abc53bfc3</CorporateInfo>
                              <CorporateInfo name=""ConfigEngine"">navINK</CorporateInfo>
                              <CorporateInfo name=""unitOfMeasureQty"">1</CorporateInfo>
                              <CorporateInfo name=""unitTransferCost"">0.000000</CorporateInfo>
                              <CorporateInfo name=""SellCode"">E</CorporateInfo>
                            </CustomerIdentification>
                            <PartnerItemDetail type=""point"" lineNumber=""1002"" quantity=""1"" unitOfMeasure=""EA"">
                              <Item id=""1770"" />
                              <Price valueType=""unit"">
                                <Money currency=""USD"">0.000000</Money>
                              </Price>
                              <Price valueType=""extended"">
                                <Money currency=""USD"">0.00</Money>
                              </Price>
                            </PartnerItemDetail>
                            <PartnerItemDetail type=""production"" lineNumber=""1002"" quantity=""1"" unitOfMeasure=""EA"">
                              <Item id=""1770"" />
                              <Price valueType=""unit"">
                                <Money currency=""USD"">0.000000</Money>
                              </Price>
                              <Price valueType=""extended"">
                                <Money currency=""USD"">0.00</Money>
                              </Price>
                            </PartnerItemDetail>
                          </LineItem>
                        </OrderRequest>
                      </Request>
                    </ICSMXML>
                    "
                    ;
        }
    }
}

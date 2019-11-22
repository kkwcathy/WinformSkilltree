<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

  <xsl:template match="/">
    <html>
      <body>
        <br></br>
        <br></br>
        <center>
        <xsl:for-each select="job">
        <h2>
          <xsl:value-of select="name"/>
        </h2>
          <br></br>
        </xsl:for-each>
          <table border="1">
            <tr bgcolor="#A0E0EA">
              <th>스킬이름</th>
              <th>설명</th>
              <th>타입</th>
              <th>마스터 레벨</th>
            </tr>
            <xsl:for-each select="job/skill">
              <tr>
                <td>
                  <xsl:value-of select="@name"/>
                </td>
                <td>
                  <xsl:value-of select="explanation"/>
                </td>
                <td>
                  <xsl:value-of select="type"/>
                </td>
                <td>
                  <xsl:value-of select="master_level"/>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </center>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

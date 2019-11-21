<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html"/>

  <xsl:template match="/">
    <html>
      <body>
        <h2>직업정보</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>이름</th>
            <th>설명</th>
            <th>타입</th>
            <th>레벨</th>
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
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>
  <xsl:template match="/">
    <html>
      <body>
            <xsl:for-each select="/students/student">
              <ul>
                Student:
                <li>
                Name: <xsl:value-of select="name"/>
              </li>
              <li>
                Sex: <xsl:value-of select="sex"/>
              </li>
              <li>
                Birthday: <xsl:value-of select="birthday"/>
              </li>
              <li>
                Phone: <xsl:value-of select="phone"/>
              </li>
              <li>
                Email: <xsl:value-of select="email"/>
              </li>
              <li>
                Course: <xsl:value-of select="course"/>
              </li>
              <li>
                Specialty: <xsl:value-of select="specialty"/>
              </li>
              <li>
                Faculty number: <xsl:value-of select="faculty-number"/>
              </li>
              <li>
                  <xsl:for-each select="current()/exams/exam">
                    <ul> Exam:
                    <li>
                      <xsl:value-of select="name"/>
                    </li>
                    <li>
                      <xsl:value-of select="tutor"/>
                    </li>
                    <li>
                      <xsl:value-of select="score"/>
                    </li>
                    </ul>
                  </xsl:for-each>
              </li>
              </ul>
            </xsl:for-each>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

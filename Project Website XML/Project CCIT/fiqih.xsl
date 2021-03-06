<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <xsl:for-each select="artikel/fiqih">
        <xsl:if test="kategori[.='Fiqih']">
          <table border="0" width="100%">
          <div class="fiqihpic">
            <div style="border:1px solid #000;width:100%;">
            <tr>
                <td><center><img src="img_artikel/{gambar}" width="100px" height="150px"/></center></td>
                <td valign="top">
                  <table border="0">
                  <tr>
                  <td><b>Judul</b></td>
                  <td>:</td>
                  <td><xsl:value-of select="judul"/></td>
                  </tr>
                  <tr>
                  <td><b>Tanggal</b></td>
                  <td>:</td>
                  <td><xsl:value-of select="tanggal"/></td>
                  </tr>
                  <tr>
                  <td><b>Penulis</b></td>
                  <td>:</td>
                  <td><xsl:value-of select="penulis"/></td>
                  </tr>
                  <tr>
                  <td><b>Sumber</b></td>
                  <td>:</td>
                  <td><xsl:value-of select="sumber"/></td>
                  </tr>
                </table>
                <tr>
                  <td><xsl:value-of select="isiArtikel"/></td>
                  </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel2"/></td>
                  </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel3"/></td>
                </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel4"/></td>
                  </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel5"/></td>
                </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel6"/></td>
                  </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel7"/></td>
                </tr>
                  <tr>
                  <td><xsl:value-of select="isiArtikel8"/></td>
                </tr>
                </td>
            </tr>
          </div>
          </div>
        </table>
        </xsl:if>
      </xsl:for-each>
    </html>
  </xsl:template>
</xsl:stylesheet>
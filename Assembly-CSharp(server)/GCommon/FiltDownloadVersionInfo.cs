using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FC3 RID: 4035
	[Token(Token = "0x2000FC3")]
	public class FiltDownloadVersionInfo : DownloadVersionInfo
	{
		// Token: 0x06003AF1 RID: 15089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x2113D08", Offset = "0x2113D08", VA = "0x7BBC913D08")]
		public FiltDownloadVersionInfo(bool isRemote, ResDownloadType download_type)
		{
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x2113D90", Offset = "0x2113D90", VA = "0x7BBC913D90", Slot = "4")]
		protected override bool ParseFile(string content, bool from_local = false)
		{
			return default(bool);
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x21150C0", Offset = "0x21150C0", VA = "0x7BBC9150C0", Slot = "6")]
		public override ResErrorCode SaveFileInfo(ResUpdateDownloadContext context)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x2115C9C", Offset = "0x2115C9C", VA = "0x7BBC915C9C", Slot = "5")]
		public override void ClearFileInfoList()
		{
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x211600C", Offset = "0x211600C", VA = "0x7BBC91600C")]
		public Dictionary<string, ResVersionInfo.FileInfo> GetPrefiltInfoList()
		{
			return null;
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x2116014", Offset = "0x2116014", VA = "0x7BBC916014")]
		public void AddPrefiltFileInfo(ResVersionInfo.FileInfo fileInfo)
		{
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x2114598", Offset = "0x2114598", VA = "0x7BBC914598")]
		private string[] FiltFifleInfo(string content)
		{
			return null;
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x2114858", Offset = "0x2114858", VA = "0x7BBC914858")]
		private void GeneratePreFiltFileInfo(string content, bool from_local = false)
		{
		}

		// Token: 0x04004C87 RID: 19591
		[Token(Token = "0x4004C87")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, ResVersionInfo.FileInfo> m_BeforeFiltFileInfos;
	}
}

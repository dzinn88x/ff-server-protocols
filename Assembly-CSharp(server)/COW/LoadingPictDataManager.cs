using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CE5 RID: 7397
	[Token(Token = "0x2001CE5")]
	public class LoadingPictDataManager : SingletonModule<LoadingPictDataManager>
	{
		// Token: 0x0600A15F RID: 41311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A15F")]
		[Address(RVA = "0x140580C", Offset = "0x140580C", VA = "0x7BBBC0580C", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A160")]
		[Address(RVA = "0x140589C", Offset = "0x140589C", VA = "0x7BBBC0589C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A161")]
		[Address(RVA = "0x1405BB0", Offset = "0x1405BB0", VA = "0x7BBBC05BB0")]
		public void OnGetCDNList(params object[] obj)
		{
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A162")]
		[Address(RVA = "0x1405DDC", Offset = "0x1405DDC", VA = "0x7BBBC05DDC")]
		public LoadingPictResource GetRandomLoadingPict(string key)
		{
			return null;
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A163")]
		[Address(RVA = "0x1405F70", Offset = "0x1405F70", VA = "0x7BBBC05F70")]
		public List<LoadingPictResource> GetLoadingPictsList(string key)
		{
			return null;
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A164")]
		[Address(RVA = "0x1405ADC", Offset = "0x1405ADC", VA = "0x7BBBC05ADC")]
		private string GenerateKey(LoadingPictData pictData)
		{
			return null;
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A165")]
		[Address(RVA = "0x1405FF0", Offset = "0x1405FF0", VA = "0x7BBBC05FF0")]
		public LoadingPictDataManager()
		{
		}

		// Token: 0x0400A7E7 RID: 42983
		[Token(Token = "0x400A7E7")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, List<LoadingPictResource>> m_dictPictData;

		// Token: 0x0400A7E8 RID: 42984
		[Token(Token = "0x400A7E8")]
		[FieldOffset(Offset = "0x20")]
		private List<LoadingPictResource> m_listCDNRes;
	}
}

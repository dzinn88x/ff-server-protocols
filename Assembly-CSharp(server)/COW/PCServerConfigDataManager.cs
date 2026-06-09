using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF4 RID: 7412
	[Token(Token = "0x2001CF4")]
	internal class PCServerConfigDataManager : SingletonModule<PCServerConfigDataManager>
	{
		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600A19F RID: 41375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A9E")]
		public ServerListConfig ServerListConfig
		{
			[Token(Token = "0x600A19F")]
			[Address(RVA = "0x203BE90", Offset = "0x203BE90", VA = "0x7BBC83BE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A0")]
		[Address(RVA = "0x203BE98", Offset = "0x203BE98", VA = "0x7BBC83BE98", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A1")]
		[Address(RVA = "0x203C104", Offset = "0x203C104", VA = "0x7BBC83C104")]
		public void OverrideGameConfig(object data)
		{
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A2")]
		[Address(RVA = "0x203C2D4", Offset = "0x203C2D4", VA = "0x7BBC83C2D4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A3")]
		[Address(RVA = "0x203C2D8", Offset = "0x203C2D8", VA = "0x7BBC83C2D8")]
		public PCServerConfigDataManager()
		{
		}

		// Token: 0x0400A80B RID: 43019
		[Token(Token = "0x400A80B")]
		private const string overrideFileName = "serverList.json";

		// Token: 0x0400A80C RID: 43020
		[Token(Token = "0x400A80C")]
		[FieldOffset(Offset = "0x18")]
		private ServerListConfig m_ServerListConfig;
	}
}

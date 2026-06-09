using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CB0 RID: 7344
	[Token(Token = "0x2001CB0")]
	public class AvatarWebDataManager : SingletonModule<AvatarWebDataManager>
	{
		// Token: 0x0600A048 RID: 41032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A048")]
		[Address(RVA = "0x21C8DCC", Offset = "0x21C8DCC", VA = "0x7BBC9C8DCC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A049")]
		[Address(RVA = "0x21C8E2C", Offset = "0x21C8E2C", VA = "0x7BBC9C8E2C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A04A")]
		[Address(RVA = "0x21C8F30", Offset = "0x21C8F30", VA = "0x7BBC9C8F30")]
		public AvatarWebDataManager()
		{
		}

		// Token: 0x0400A72C RID: 42796
		[Token(Token = "0x400A72C")]
		[FieldOffset(Offset = "0x18")]
		private List<AvatarWebData> m_Data;
	}
}

using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001308 RID: 4872
	[Token(Token = "0x2001308")]
	internal class SparkEventData_EnterLobby : SparkEventData_Base
	{
		// Token: 0x06004D51 RID: 19793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x1B3B688", Offset = "0x1B3B688", VA = "0x7BBC33B688", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x1B3B6D0", Offset = "0x1B3B6D0", VA = "0x7BBC33B6D0")]
		public SparkEventData_EnterLobby()
		{
		}

		// Token: 0x040074FB RID: 29947
		[Token(Token = "0x40074FB")]
		[FieldOffset(Offset = "0x18")]
		public string nickname;

		// Token: 0x040074FC RID: 29948
		[Token(Token = "0x40074FC")]
		[FieldOffset(Offset = "0x20")]
		public string region;

		// Token: 0x040074FD RID: 29949
		[Token(Token = "0x40074FD")]
		[FieldOffset(Offset = "0x28")]
		public string language;
	}
}

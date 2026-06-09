using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001337 RID: 4919
	[Token(Token = "0x2001337")]
	public class AutoTaskPetLevelUp : AutoPopupTask
	{
		// Token: 0x06004DFD RID: 19965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x155AAF4", Offset = "0x155AAF4", VA = "0x7BBBD5AAF4", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x00017B20 File Offset: 0x00015D20
		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x155AAFC", Offset = "0x155AAFC", VA = "0x7BBBD5AAFC", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x00017B38 File Offset: 0x00015D38
		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0x155AD18", Offset = "0x155AD18", VA = "0x7BBBD5AD18", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E00")]
		[Address(RVA = "0x155ADB8", Offset = "0x155ADB8", VA = "0x7BBBD5ADB8")]
		public AutoTaskPetLevelUp()
		{
		}

		// Token: 0x0400754C RID: 30028
		[Token(Token = "0x400754C")]
		[FieldOffset(Offset = "0x10")]
		private UIPetLevelUpController m_PetLevelUpUI;
	}
}

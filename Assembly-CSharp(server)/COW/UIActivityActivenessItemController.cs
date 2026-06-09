using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020013D9 RID: 5081
	[Token(Token = "0x20013D9")]
	public class UIActivityActivenessItemController : MonoBehaviour
	{
		// Token: 0x0600535C RID: 21340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600535C")]
		[Address(RVA = "0x1A416AC", Offset = "0x1A416AC", VA = "0x7BBC2416AC")]
		public void SetData(ClientActivityDesc data, bool bgtype, bool reload)
		{
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00018EA0 File Offset: 0x000170A0
		[Token(Token = "0x600535D")]
		[Address(RVA = "0x1A43608", Offset = "0x1A43608", VA = "0x7BBC243608")]
		public uint GetActivityId()
		{
			return 0U;
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600535E")]
		[Address(RVA = "0x1A436A8", Offset = "0x1A436A8", VA = "0x7BBC2436A8")]
		public UIActivityActivenessItemController()
		{
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00018EB8 File Offset: 0x000170B8
		[Token(Token = "0x600535F")]
		[Address(RVA = "0x1A436B8", Offset = "0x1A436B8", VA = "0x7BBC2436B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E4B0", Offset = "0x113E4B0")]
		private bool <SetData>b__8_0(AwardDesc e)
		{
			return default(bool);
		}

		// Token: 0x0400790D RID: 30989
		[Token(Token = "0x400790D")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Desc;

		// Token: 0x0400790E RID: 30990
		[Token(Token = "0x400790E")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ActivenessValue;

		// Token: 0x0400790F RID: 30991
		[Token(Token = "0x400790F")]
		[FieldOffset(Offset = "0x28")]
		public ActivityAwardDescription activityAwardDescription;

		// Token: 0x04007910 RID: 30992
		[Token(Token = "0x4007910")]
		[FieldOffset(Offset = "0x30")]
		private EInventory.AwardType m_AwardType;

		// Token: 0x04007911 RID: 30993
		[Token(Token = "0x4007911")]
		[FieldOffset(Offset = "0x38")]
		public GameObject bg1;

		// Token: 0x04007912 RID: 30994
		[Token(Token = "0x4007912")]
		[FieldOffset(Offset = "0x40")]
		public GameObject bg2;

		// Token: 0x04007913 RID: 30995
		[Token(Token = "0x4007913")]
		[FieldOffset(Offset = "0x48")]
		public UISprite activenessFlag;

		// Token: 0x04007914 RID: 30996
		[Token(Token = "0x4007914")]
		[FieldOffset(Offset = "0x50")]
		private uint m_ActivityId;
	}
}

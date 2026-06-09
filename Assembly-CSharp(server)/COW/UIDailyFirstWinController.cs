using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001781 RID: 6017
	[Token(Token = "0x2001781")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F22CC", Offset = "0x10F22CC")]
	public class UIDailyFirstWinController : UIBaseController
	{
		// Token: 0x0600722C RID: 29228 RVA: 0x0001FC98 File Offset: 0x0001DE98
		[Token(Token = "0x600722C")]
		[Address(RVA = "0x1BACF90", Offset = "0x1BACF90", VA = "0x7BBC3ACF90")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722D")]
		[Address(RVA = "0x1BACFE0", Offset = "0x1BACFE0", VA = "0x7BBC3ACFE0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722E")]
		[Address(RVA = "0x1BAD5C8", Offset = "0x1BAD5C8", VA = "0x7BBC3AD5C8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722F")]
		[Address(RVA = "0x1BAD194", Offset = "0x1BAD194", VA = "0x7BBC3AD194")]
		private void RefreshData()
		{
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007230")]
		[Address(RVA = "0x1BAD5D0", Offset = "0x1BAD5D0", VA = "0x7BBC3AD5D0")]
		public UIDailyFirstWinController()
		{
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007231")]
		[Address(RVA = "0x1BAD5D8", Offset = "0x1BAD5D8", VA = "0x7BBC3AD5D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141960", Offset = "0x1141960")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007232")]
		[Address(RVA = "0x1BAD660", Offset = "0x1BAD660", VA = "0x7BBC3AD660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141970", Offset = "0x1141970")]
		private void <OnUIInit>b__3_1()
		{
		}

		// Token: 0x04008B54 RID: 35668
		[Token(Token = "0x4008B54")]
		[FieldOffset(Offset = "0x58")]
		private UIDailyFirstWinView m_View;

		// Token: 0x04008B55 RID: 35669
		[Token(Token = "0x4008B55")]
		[FieldOffset(Offset = "0x60")]
		private LadderMatchDaily m_DailyInfo;
	}
}

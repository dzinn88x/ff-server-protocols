using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C05 RID: 7173
	[Token(Token = "0x2001C05")]
	public class UIHUDWereWolvesHumanKilled : UIBaseController
	{
		// Token: 0x06009C05 RID: 39941 RVA: 0x00028F68 File Offset: 0x00027168
		[Token(Token = "0x6009C05")]
		[Address(RVA = "0x1D57820", Offset = "0x1D57820", VA = "0x7BBC557820")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C06")]
		[Address(RVA = "0x1D57870", Offset = "0x1D57870", VA = "0x7BBC557870", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C07 RID: 39943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C07")]
		[Address(RVA = "0x1D578D4", Offset = "0x1D578D4", VA = "0x7BBC5578D4")]
		public void ShowData(int humanColorIndex, int wolfColorIndex)
		{
		}

		// Token: 0x06009C08 RID: 39944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C08")]
		[Address(RVA = "0x1D57A68", Offset = "0x1D57A68", VA = "0x7BBC557A68")]
		private void SetShowInfo(UILabel indexLabel, UISprite IconSprite, int colorIndex)
		{
		}

		// Token: 0x06009C09 RID: 39945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C09")]
		[Address(RVA = "0x1D57D1C", Offset = "0x1D57D1C", VA = "0x7BBC557D1C")]
		public UIHUDWereWolvesHumanKilled()
		{
		}

		// Token: 0x06009C0A RID: 39946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C0A")]
		[Address(RVA = "0x1D57D24", Offset = "0x1D57D24", VA = "0x7BBC557D24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145264", Offset = "0x1145264")]
		private void <ShowData>b__3_0()
		{
		}

		// Token: 0x0400A215 RID: 41493
		[Token(Token = "0x400A215")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDWereWolvesHumanKilledView m_View;
	}
}

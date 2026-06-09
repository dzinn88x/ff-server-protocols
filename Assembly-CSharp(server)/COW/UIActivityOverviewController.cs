using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013F9 RID: 5113
	[Token(Token = "0x20013F9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC398", Offset = "0x10EC398")]
	public class UIActivityOverviewController : UIActivityContentController
	{
		// Token: 0x0600541E RID: 21534 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x600541E")]
		[Address(RVA = "0x195669C", Offset = "0x195669C", VA = "0x7BBC15669C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600541F")]
		[Address(RVA = "0x19566EC", Offset = "0x19566EC", VA = "0x7BBC1566EC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005420")]
		[Address(RVA = "0x1956750", Offset = "0x1956750", VA = "0x7BBC156750", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005421")]
		[Address(RVA = "0x195700C", Offset = "0x195700C", VA = "0x7BBC15700C", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005422")]
		[Address(RVA = "0x1957140", Offset = "0x1957140", VA = "0x7BBC157140")]
		public UIActivityOverviewController()
		{
		}

		// Token: 0x04007999 RID: 31129
		[Token(Token = "0x4007999")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityOverviewView m_View;

		// Token: 0x0400799A RID: 31130
		[Token(Token = "0x400799A")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400799B RID: 31131
		[Token(Token = "0x400799B")]
		[FieldOffset(Offset = "0x68")]
		private List<UIActivityOverviewItemController> m_Items;

		// Token: 0x020013FA RID: 5114
		[Token(Token = "0x20013FA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC3D0", Offset = "0x10EC3D0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005424 RID: 21540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005424")]
			[Address(RVA = "0x1957214", Offset = "0x1957214", VA = "0x7BBC157214")]
			public <>c()
			{
			}

			// Token: 0x06005425 RID: 21541 RVA: 0x00019200 File Offset: 0x00017400
			[Token(Token = "0x6005425")]
			[Address(RVA = "0x195721C", Offset = "0x195721C", VA = "0x7BBC15721C")]
			internal int <SetData>b__5_0(AdvertDesc x, AdvertDesc y)
			{
				return 0;
			}

			// Token: 0x0400799C RID: 31132
			[Token(Token = "0x400799C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIActivityOverviewController.<>c <>9;

			// Token: 0x0400799D RID: 31133
			[Token(Token = "0x400799D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AdvertDesc> <>9__5_0;
		}
	}
}

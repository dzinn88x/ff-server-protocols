using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015A2 RID: 5538
	[Token(Token = "0x20015A2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEEC4", Offset = "0x10EEEC4")]
	public class UIMallItemWidgetController : UIMallItemBaseController
	{
		// Token: 0x06006156 RID: 24918 RVA: 0x0001C098 File Offset: 0x0001A298
		[Token(Token = "0x6006156")]
		[Address(RVA = "0x1DED090", Offset = "0x1DED090", VA = "0x7BBC5ED090")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006157")]
		[Address(RVA = "0x1DED0E0", Offset = "0x1DED0E0", VA = "0x7BBC5ED0E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006158")]
		[Address(RVA = "0x1DED1BC", Offset = "0x1DED1BC", VA = "0x7BBC5ED1BC")]
		private void SetParentWidget()
		{
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006159")]
		[Address(RVA = "0x1DED774", Offset = "0x1DED774", VA = "0x7BBC5ED774")]
		public UIMallItemWidgetController()
		{
		}

		// Token: 0x04008149 RID: 33097
		[Token(Token = "0x4008149")]
		[FieldOffset(Offset = "0x220")]
		public UIStandardItemMAXBView m_View;
	}
}

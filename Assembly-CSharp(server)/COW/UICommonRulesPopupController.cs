using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001763 RID: 5987
	[Token(Token = "0x2001763")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1F4C", Offset = "0x10F1F4C")]
	public class UICommonRulesPopupController : UIPopupWindowController, IEasyList
	{
		// Token: 0x17000933 RID: 2355
		// (set) Token: 0x060070EB RID: 28907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000933")]
		public string InitSelectRule
		{
			[Token(Token = "0x60070EB")]
			[Address(RVA = "0x1813EB0", Offset = "0x1813EB0", VA = "0x7BBC013EB0")]
			set
			{
			}
		}

		// Token: 0x17000934 RID: 2356
		// (set) Token: 0x060070EC RID: 28908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000934")]
		public RuleType Type
		{
			[Token(Token = "0x60070EC")]
			[Address(RVA = "0x1813EB8", Offset = "0x1813EB8", VA = "0x7BBC013EB8")]
			set
			{
			}
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x0001F920 File Offset: 0x0001DB20
		[Token(Token = "0x60070ED")]
		[Address(RVA = "0x1814050", Offset = "0x1814050", VA = "0x7BBC014050")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070EE")]
		[Address(RVA = "0x18140A0", Offset = "0x18140A0", VA = "0x7BBC0140A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070EF")]
		[Address(RVA = "0x18141E8", Offset = "0x18141E8", VA = "0x7BBC0141E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F0")]
		[Address(RVA = "0x18142B4", Offset = "0x18142B4", VA = "0x7BBC0142B4")]
		private void OnSelectRule(params object[] param)
		{
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F1")]
		[Address(RVA = "0x181476C", Offset = "0x181476C", VA = "0x7BBC01476C", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F2")]
		[Address(RVA = "0x1814800", Offset = "0x1814800", VA = "0x7BBC014800", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070F3")]
		[Address(RVA = "0x1814830", Offset = "0x1814830", VA = "0x7BBC014830")]
		public UICommonRulesPopupController()
		{
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x0001F938 File Offset: 0x0001DB38
		[Token(Token = "0x60070F4")]
		[Address(RVA = "0x1814888", Offset = "0x1814888", VA = "0x7BBC014888")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11415EC", Offset = "0x11415EC")]
		private bool <set_Type>b__7_0(RuleMapping e)
		{
			return default(bool);
		}

		// Token: 0x04008A98 RID: 35480
		[Token(Token = "0x4008A98")]
		[FieldOffset(Offset = "0x98")]
		private UICommonRulesPopupView m_View;

		// Token: 0x04008A99 RID: 35481
		[Token(Token = "0x4008A99")]
		[FieldOffset(Offset = "0xA0")]
		private RuleType m_Type;

		// Token: 0x04008A9A RID: 35482
		[Token(Token = "0x4008A9A")]
		[FieldOffset(Offset = "0xA8")]
		private string m_InitSelectRule;

		// Token: 0x04008A9B RID: 35483
		[Token(Token = "0x4008A9B")]
		[FieldOffset(Offset = "0xB0")]
		public object m_ExtralData;

		// Token: 0x04008A9C RID: 35484
		[Token(Token = "0x4008A9C")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject _currentScrollViewObj;
	}
}

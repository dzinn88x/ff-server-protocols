using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001787 RID: 6023
	[Token(Token = "0x2001787")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F23E4", Offset = "0x10F23E4")]
	public class UIApplyDeputyCaptainController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007271 RID: 29297 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		[Token(Token = "0x6007271")]
		[Address(RVA = "0x1B153CC", Offset = "0x1B153CC", VA = "0x7BBC3153CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007272")]
		[Address(RVA = "0x1B1541C", Offset = "0x1B1541C", VA = "0x7BBC31541C", Slot = "28")]
		public override string Rule()
		{
			return null;
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007273")]
		[Address(RVA = "0x1B15464", Offset = "0x1B15464", VA = "0x7BBC315464", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007274")]
		[Address(RVA = "0x1B155DC", Offset = "0x1B155DC", VA = "0x7BBC3155DC", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		[Token(Token = "0x6007275")]
		[Address(RVA = "0x1B15690", Offset = "0x1B15690", VA = "0x7BBC315690", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007276")]
		[Address(RVA = "0x1B15698", Offset = "0x1B15698", VA = "0x7BBC315698", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007277")]
		[Address(RVA = "0x1B15878", Offset = "0x1B15878", VA = "0x7BBC315878")]
		private void OnApplyBtnClick()
		{
		}

		// Token: 0x06007278 RID: 29304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007278")]
		[Address(RVA = "0x1B158A8", Offset = "0x1B158A8", VA = "0x7BBC3158A8")]
		public UIApplyDeputyCaptainController()
		{
		}

		// Token: 0x04008B6F RID: 35695
		[Token(Token = "0x4008B6F")]
		[FieldOffset(Offset = "0x98")]
		private UIApplyDeputyCaptainView m_View;

		// Token: 0x04008B70 RID: 35696
		[Token(Token = "0x4008B70")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelClan m_ModelClan;
	}
}

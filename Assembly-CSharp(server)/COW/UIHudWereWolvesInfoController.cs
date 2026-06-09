using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001996 RID: 6550
	[Token(Token = "0x2001996")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6A6C", Offset = "0x10F6A6C")]
	public class UIHudWereWolvesInfoController : UIBaseController
	{
		// Token: 0x060085E4 RID: 34276 RVA: 0x000244C8 File Offset: 0x000226C8
		[Token(Token = "0x60085E4")]
		[Address(RVA = "0x1D11E74", Offset = "0x1D11E74", VA = "0x7BBC511E74")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E5")]
		[Address(RVA = "0x1D11EC4", Offset = "0x1D11EC4", VA = "0x7BBC511EC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E6")]
		[Address(RVA = "0x1D122F4", Offset = "0x1D122F4", VA = "0x7BBC5122F4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060085E7 RID: 34279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E7")]
		[Address(RVA = "0x1D120D4", Offset = "0x1D120D4", VA = "0x7BBC5120D4")]
		private void OnCurrentPointChange(params object[] data)
		{
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E8")]
		[Address(RVA = "0x1D12468", Offset = "0x1D12468", VA = "0x7BBC512468")]
		private void OnAlertInfo(params object[] data)
		{
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085E9")]
		[Address(RVA = "0x1D126B0", Offset = "0x1D126B0", VA = "0x7BBC5126B0")]
		private void OnTaskCompleteTutorialCome(params object[] data)
		{
		}

		// Token: 0x060085EA RID: 34282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085EA")]
		[Address(RVA = "0x1D12794", Offset = "0x1D12794", VA = "0x7BBC512794")]
		private void LateUpdate()
		{
		}

		// Token: 0x060085EB RID: 34283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085EB")]
		[Address(RVA = "0x1D12A7C", Offset = "0x1D12A7C", VA = "0x7BBC512A7C")]
		public UIHudWereWolvesInfoController()
		{
		}

		// Token: 0x060085EC RID: 34284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60085EC")]
		[Address(RVA = "0x1D12A84", Offset = "0x1D12A84", VA = "0x7BBC512A84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143478", Offset = "0x1143478")]
		private void <OnTaskCompleteTutorialCome>b__7_0()
		{
		}

		// Token: 0x04009555 RID: 38229
		[Token(Token = "0x4009555")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesInfoView m_View;

		// Token: 0x04009556 RID: 38230
		[Token(Token = "0x4009556")]
		[FieldOffset(Offset = "0x60")]
		private float m_AlertTimer;
	}
}

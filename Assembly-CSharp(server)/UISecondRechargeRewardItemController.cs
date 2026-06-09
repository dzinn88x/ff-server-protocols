using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
internal class UISecondRechargeRewardItemController : UIBaseController
{
	// Token: 0x0600055D RID: 1373 RVA: 0x00002F88 File Offset: 0x00001188
	[Token(Token = "0x600055D")]
	[Address(RVA = "0x1FCC87C", Offset = "0x1FCC87C", VA = "0x7BBC7CC87C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00002FA0 File Offset: 0x000011A0
	[Token(Token = "0x600055E")]
	[Address(RVA = "0x1FCC8CC", Offset = "0x1FCC8CC", VA = "0x7BBC7CC8CC")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055F")]
	[Address(RVA = "0x1FCC910", Offset = "0x1FCC910", VA = "0x7BBC7CC910", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000560")]
	[Address(RVA = "0x1FCCA9C", Offset = "0x1FCCA9C", VA = "0x7BBC7CCA9C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000561")]
	[Address(RVA = "0x1FCC1F0", Offset = "0x1FCC1F0", VA = "0x7BBC7CC1F0")]
	public void SetData(ClientActivityDesc activity)
	{
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000562")]
	[Address(RVA = "0x1FCCB40", Offset = "0x1FCCB40", VA = "0x7BBC7CCB40")]
	private void OnClickItem()
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000563")]
	[Address(RVA = "0x1FCCFE0", Offset = "0x1FCCFE0", VA = "0x7BBC7CCFE0")]
	private void RequestAward()
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000564")]
	[Address(RVA = "0x1FCC3D8", Offset = "0x1FCC3D8", VA = "0x7BBC7CC3D8")]
	public void UpdateUI(uint state)
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000565")]
	[Address(RVA = "0x1FCD1A4", Offset = "0x1FCD1A4", VA = "0x7BBC7CD1A4")]
	public UISecondRechargeRewardItemController()
	{
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000566")]
	[Address(RVA = "0x1FCD1AC", Offset = "0x1FCD1AC", VA = "0x7BBC7CD1AC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132E34", Offset = "0x1132E34")]
	private void <RequestAward>b__12_0()
	{
	}

	// Token: 0x0400048C RID: 1164
	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x58")]
	private UISecondRechargeRewardItemView m_View;

	// Token: 0x0400048D RID: 1165
	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x60")]
	private uint m_DelayCallID;

	// Token: 0x0400048E RID: 1166
	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsRequestResponse;

	// Token: 0x0400048F RID: 1167
	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x68")]
	private ClientActivityDesc m_ActivityDesc;

	// Token: 0x04000490 RID: 1168
	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x70")]
	private UISecondRechargeRewardItemController.OperateStatus m_OpState;

	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	private enum OperateStatus
	{
		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		None,
		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		GoTo,
		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		UnFinished,
		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		Available,
		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		Received
	}

	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1F50", Offset = "0x10E1F50")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1FCD21C", Offset = "0x1FCD21C", VA = "0x7BBC7CD21C")]
		public <>c()
		{
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1FCD224", Offset = "0x1FCD224", VA = "0x7BBC7CD224")]
		internal BaseItemInfo <OnClickItem>b__11_0(AwardDesc s)
		{
			return null;
		}

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UISecondRechargeRewardItemController.<>c <>9;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<AwardDesc, BaseItemInfo> <>9__11_0;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001351 RID: 4945
	[Token(Token = "0x2001351")]
	public class ActivityExchangeDescription : MonoBehaviour
	{
		// Token: 0x06004E9B RID: 20123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x1F9C5BC", Offset = "0x1F9C5BC", VA = "0x7BBC79C5BC")]
		private void Start()
		{
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x1F9C670", Offset = "0x1F9C670", VA = "0x7BBC79C670")]
		private void Update()
		{
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9D")]
		[Address(RVA = "0x1F9C674", Offset = "0x1F9C674", VA = "0x7BBC79C674")]
		public void SetData(ClientActivityDesc desc)
		{
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x1F9D8E0", Offset = "0x1F9D8E0", VA = "0x7BBC79D8E0")]
		public void DisableSplitLineUI()
		{
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E9F")]
		[Address(RVA = "0x1F9C73C", Offset = "0x1F9C73C", VA = "0x7BBC79C73C")]
		private void SetOperateButtonUI()
		{
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x1F9CCE8", Offset = "0x1F9CCE8", VA = "0x7BBC79CCE8")]
		private void CreateConsumeItems()
		{
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x1F9D1EC", Offset = "0x1F9D1EC", VA = "0x7BBC79D1EC")]
		private void CreateAwardItems(List<AwardDesc> awards)
		{
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x1F9D998", Offset = "0x1F9D998", VA = "0x7BBC79D998")]
		private void OnOperate()
		{
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA3")]
		[Address(RVA = "0x1F9DE9C", Offset = "0x1F9DE9C", VA = "0x7BBC79DE9C")]
		public void Reload()
		{
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA4")]
		[Address(RVA = "0x1F9DFBC", Offset = "0x1F9DFBC", VA = "0x7BBC79DFBC")]
		public ActivityExchangeDescription()
		{
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EA5")]
		[Address(RVA = "0x1F9E014", Offset = "0x1F9E014", VA = "0x7BBC79E014")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DEC8", Offset = "0x113DEC8")]
		private void <OnOperate>b__23_0()
		{
		}

		// Token: 0x040075BC RID: 30140
		[Token(Token = "0x40075BC")]
		[FieldOffset(Offset = "0x18")]
		public ActivityAwardItem ConsumeItemTemplate;

		// Token: 0x040075BD RID: 30141
		[Token(Token = "0x40075BD")]
		[FieldOffset(Offset = "0x20")]
		public ActivityAwardItem ExchangeItem;

		// Token: 0x040075BE RID: 30142
		[Token(Token = "0x40075BE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OperateButton;

		// Token: 0x040075BF RID: 30143
		[Token(Token = "0x40075BF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite OperateGray;

		// Token: 0x040075C0 RID: 30144
		[Token(Token = "0x40075C0")]
		[FieldOffset(Offset = "0x38")]
		public UISprite OperateYellow;

		// Token: 0x040075C1 RID: 30145
		[Token(Token = "0x40075C1")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SplitLineSpr;

		// Token: 0x040075C2 RID: 30146
		[Token(Token = "0x40075C2")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OperateTitle;

		// Token: 0x040075C3 RID: 30147
		[Token(Token = "0x40075C3")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Progress;

		// Token: 0x040075C4 RID: 30148
		[Token(Token = "0x40075C4")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Equal;

		// Token: 0x040075C5 RID: 30149
		[Token(Token = "0x40075C5")]
		[FieldOffset(Offset = "0x60")]
		public float Space;

		// Token: 0x040075C6 RID: 30150
		[Token(Token = "0x40075C6")]
		[FieldOffset(Offset = "0x68")]
		private ClientActivityDesc m_Desc;

		// Token: 0x040075C7 RID: 30151
		[Token(Token = "0x40075C7")]
		[FieldOffset(Offset = "0x70")]
		private ActivityExchangeDescription.OperateStatus m_OperateStatus;

		// Token: 0x040075C8 RID: 30152
		[Token(Token = "0x40075C8")]
		[FieldOffset(Offset = "0x78")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040075C9 RID: 30153
		[Token(Token = "0x40075C9")]
		[FieldOffset(Offset = "0x80")]
		private List<ActivityAwardItem> m_ConsumeItemUIs;

		// Token: 0x040075CA RID: 30154
		[Token(Token = "0x40075CA")]
		[FieldOffset(Offset = "0x88")]
		private Color32 m_GrayColor;

		// Token: 0x02001352 RID: 4946
		[Token(Token = "0x2001352")]
		private enum OperateStatus
		{
			// Token: 0x040075CC RID: 30156
			[Token(Token = "0x40075CC")]
			None,
			// Token: 0x040075CD RID: 30157
			[Token(Token = "0x40075CD")]
			Exchange,
			// Token: 0x040075CE RID: 30158
			[Token(Token = "0x40075CE")]
			ExchangeNo,
			// Token: 0x040075CF RID: 30159
			[Token(Token = "0x40075CF")]
			ExchangeFinished
		}
	}
}

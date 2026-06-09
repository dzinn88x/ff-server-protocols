using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013E6 RID: 5094
	[Token(Token = "0x20013E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC178", Offset = "0x10EC178")]
	public class UIActivityCollectionSigninItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060053AE RID: 21422 RVA: 0x00018F90 File Offset: 0x00017190
		[Token(Token = "0x60053AE")]
		[Address(RVA = "0x1A48AC8", Offset = "0x1A48AC8", VA = "0x7BBC248AC8")]
		public bool IsSignButNotClaimed()
		{
			return default(bool);
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00018FA8 File Offset: 0x000171A8
		[Token(Token = "0x60053AF")]
		[Address(RVA = "0x1A49570", Offset = "0x1A49570", VA = "0x7BBC249570")]
		public bool IsNowDay()
		{
			return default(bool);
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00018FC0 File Offset: 0x000171C0
		[Token(Token = "0x60053B0")]
		[Address(RVA = "0x1A49D78", Offset = "0x1A49D78", VA = "0x7BBC249D78")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B1")]
		[Address(RVA = "0x1A49DC8", Offset = "0x1A49DC8", VA = "0x7BBC249DC8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B2")]
		[Address(RVA = "0x1A49F20", Offset = "0x1A49F20", VA = "0x7BBC249F20", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B3")]
		[Address(RVA = "0x1A49F64", Offset = "0x1A49F64", VA = "0x7BBC249F64")]
		public void OnClickClaimed()
		{
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B4")]
		[Address(RVA = "0x1A48C2C", Offset = "0x1A48C2C", VA = "0x7BBC248C2C")]
		public void SetData(FestivalAttendanceItem info)
		{
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B5")]
		[Address(RVA = "0x1A49F9C", Offset = "0x1A49F9C", VA = "0x7BBC249F9C")]
		private void UpdateView()
		{
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B6")]
		[Address(RVA = "0x1A4A324", Offset = "0x1A4A324", VA = "0x7BBC24A324", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00018FD8 File Offset: 0x000171D8
		[Token(Token = "0x60053B7")]
		[Address(RVA = "0x1A4A418", Offset = "0x1A4A418", VA = "0x7BBC24A418", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B8")]
		[Address(RVA = "0x1A4A45C", Offset = "0x1A4A45C", VA = "0x7BBC24A45C")]
		public UIActivityCollectionSigninItemController()
		{
		}

		// Token: 0x04007946 RID: 31046
		[Token(Token = "0x4007946")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityCollectionSigninItemView m_View;

		// Token: 0x04007947 RID: 31047
		[Token(Token = "0x4007947")]
		[FieldOffset(Offset = "0x60")]
		private uint m_ID;

		// Token: 0x04007948 RID: 31048
		[Token(Token = "0x4007948")]
		[FieldOffset(Offset = "0x68")]
		private FestivalAttendanceItem m_Info;

		// Token: 0x04007949 RID: 31049
		[Token(Token = "0x4007949")]
		[FieldOffset(Offset = "0x70")]
		private UIModelActivity m_Model;

		// Token: 0x0400794A RID: 31050
		[Token(Token = "0x400794A")]
		private const uint GREY_COLOR = 2122219263U;

		// Token: 0x0400794B RID: 31051
		[Token(Token = "0x400794B")]
		private const uint YELLOW_COLOR = 4120519679U;

		// Token: 0x0400794C RID: 31052
		[Token(Token = "0x400794C")]
		[FieldOffset(Offset = "0x78")]
		private int m_NowDay;

		// Token: 0x0400794D RID: 31053
		[Token(Token = "0x400794D")]
		[FieldOffset(Offset = "0x80")]
		private UIStandardItemMAXBController m_AwardUI;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001049 RID: 4169
	[Token(Token = "0x2001049")]
	public class UIWrapContentExtend : UIWrapContentBase
	{
		// Token: 0x06003F93 RID: 16275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F93")]
		[Address(RVA = "0x223AD18", Offset = "0x223AD18", VA = "0x7BBCA3AD18")]
		public void InitEasyList(UIScrollView scrollView, int columns)
		{
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x00013AD0 File Offset: 0x00011CD0
		// (set) Token: 0x06003F95 RID: 16277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700074F")]
		public bool ForceResetScroll
		{
			[Token(Token = "0x6003F94")]
			[Address(RVA = "0x223AF2C", Offset = "0x223AF2C", VA = "0x7BBCA3AF2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C23C", Offset = "0x113C23C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003F95")]
			[Address(RVA = "0x223AF34", Offset = "0x223AF34", VA = "0x7BBCA3AF34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C24C", Offset = "0x113C24C")]
			set
			{
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x00013AE8 File Offset: 0x00011CE8
		[Token(Token = "0x17000750")]
		public override UIScrollView.Movement ScrollViewMovement
		{
			[Token(Token = "0x6003F96")]
			[Address(RVA = "0x223AF40", Offset = "0x223AF40", VA = "0x7BBCA3AF40", Slot = "4")]
			get
			{
				return UIScrollView.Movement.Horizontal;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x17000751")]
		public override float CellHeight
		{
			[Token(Token = "0x6003F97")]
			[Address(RVA = "0x223AF50", Offset = "0x223AF50", VA = "0x7BBCA3AF50", Slot = "5")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x00013B18 File Offset: 0x00011D18
		[Token(Token = "0x17000752")]
		public override float CellWidth
		{
			[Token(Token = "0x6003F98")]
			[Address(RVA = "0x223AF5C", Offset = "0x223AF5C", VA = "0x7BBCA3AF5C", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F99")]
		[Address(RVA = "0x223AF68", Offset = "0x223AF68", VA = "0x7BBCA3AF68", Slot = "7")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9A")]
		[Address(RVA = "0x223B04C", Offset = "0x223B04C", VA = "0x7BBCA3B04C")]
		public void ForceSetMoveDelegate()
		{
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x223B130", Offset = "0x223B130", VA = "0x7BBCA3B130", Slot = "8")]
		public virtual void ResetChilds(bool resetScroll = true, bool resortChildren = true)
		{
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x223B350", Offset = "0x223B350", VA = "0x7BBCA3B350", Slot = "9")]
		public virtual void Refresh()
		{
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x223B45C", Offset = "0x223B45C", VA = "0x7BBCA3B45C", Slot = "10")]
		protected virtual void OnMove(UIPanel panel)
		{
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x223B164", Offset = "0x223B164", VA = "0x7BBCA3B164")]
		public void SortBasedOnScrollMovement(bool resetScroll = true, bool resortChildren = true)
		{
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x223C0AC", Offset = "0x223C0AC", VA = "0x7BBCA3C0AC")]
		public void SortAlphabetically()
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00013B30 File Offset: 0x00011D30
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x223ADE0", Offset = "0x223ADE0", VA = "0x7BBCA3ADE0")]
		protected bool CacheScrollView()
		{
			return default(bool);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x223BEFC", Offset = "0x223BEFC", VA = "0x7BBCA3BEFC")]
		private void ResetChildPositions(bool resetScroll = true)
		{
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x223B460", Offset = "0x223B460", VA = "0x7BBCA3B460")]
		public void WrapContent()
		{
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA3")]
		[Address(RVA = "0x223C930", Offset = "0x223C930", VA = "0x7BBCA3C930")]
		private void OnValidate()
		{
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA4")]
		[Address(RVA = "0x223C954", Offset = "0x223C954", VA = "0x7BBCA3C954", Slot = "11")]
		protected virtual void UpdateItem(Transform item, int index)
		{
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x223C62C", Offset = "0x223C62C", VA = "0x7BBCA3C62C")]
		protected int GetRealIndex(Vector2 itemLocalPosition, bool isNature = false)
		{
			return 0;
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00013B60 File Offset: 0x00011D60
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x223C770", Offset = "0x223C770", VA = "0x7BBCA3C770")]
		protected int GetFullFillChildrenSize()
		{
			return 0;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00013B78 File Offset: 0x00011D78
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x223C490", Offset = "0x223C490", VA = "0x7BBCA3C490")]
		public Vector3 GetPositionAtIndex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x223C250", Offset = "0x223C250", VA = "0x7BBCA3C250")]
		public int GetCurrentRealIndex()
		{
			return 0;
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x223D238", Offset = "0x223D238", VA = "0x7BBCA3D238")]
		public UIWrapContentExtend()
		{
		}

		// Token: 0x04004F8A RID: 20362
		[Token(Token = "0x4004F8A")]
		[FieldOffset(Offset = "0x18")]
		public int m_columns;

		// Token: 0x04004F8B RID: 20363
		[Token(Token = "0x4004F8B")]
		[FieldOffset(Offset = "0x1C")]
		public int itemWidth;

		// Token: 0x04004F8C RID: 20364
		[Token(Token = "0x4004F8C")]
		[FieldOffset(Offset = "0x20")]
		public int itemHeight;

		// Token: 0x04004F8D RID: 20365
		[Token(Token = "0x4004F8D")]
		[FieldOffset(Offset = "0x24")]
		public bool cullContent;

		// Token: 0x04004F8E RID: 20366
		[Token(Token = "0x4004F8E")]
		[FieldOffset(Offset = "0x28")]
		public int minIndex;

		// Token: 0x04004F8F RID: 20367
		[Token(Token = "0x4004F8F")]
		[FieldOffset(Offset = "0x2C")]
		public int maxIndex;

		// Token: 0x04004F90 RID: 20368
		[Token(Token = "0x4004F90")]
		[FieldOffset(Offset = "0x30")]
		public UIWrapContentExtend.OnInitializeItem onInitializeItem;

		// Token: 0x04004F91 RID: 20369
		[Token(Token = "0x4004F91")]
		[FieldOffset(Offset = "0x38")]
		private Transform mTrans;

		// Token: 0x04004F92 RID: 20370
		[Token(Token = "0x4004F92")]
		[FieldOffset(Offset = "0x40")]
		public UIPanel mPanel;

		// Token: 0x04004F93 RID: 20371
		[Token(Token = "0x4004F93")]
		[FieldOffset(Offset = "0x48")]
		public UIScrollView mScroll;

		// Token: 0x04004F94 RID: 20372
		[Token(Token = "0x4004F94")]
		[FieldOffset(Offset = "0x50")]
		private bool mHorizontal;

		// Token: 0x04004F95 RID: 20373
		[Token(Token = "0x4004F95")]
		[FieldOffset(Offset = "0x51")]
		private bool mFirstTime;

		// Token: 0x04004F96 RID: 20374
		[Token(Token = "0x4004F96")]
		[FieldOffset(Offset = "0x58")]
		private List<Transform> mChildren;

		// Token: 0x04004F97 RID: 20375
		[Token(Token = "0x4004F97")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EB7C", Offset = "0x112EB7C")]
		private bool <ForceResetScroll>k__BackingField;

		// Token: 0x0200104A RID: 4170
		// (Invoke) Token: 0x06003FAB RID: 16299
		[Token(Token = "0x200104A")]
		public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);
	}
}

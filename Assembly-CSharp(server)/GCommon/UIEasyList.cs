using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001022 RID: 4130
	[Token(Token = "0x2001022")]
	public class UIEasyList : MonoBehaviour
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000737")]
		protected UIPanel ScrollViewPanel
		{
			[Token(Token = "0x6003E6B")]
			[Address(RVA = "0x2029808", Offset = "0x2029808", VA = "0x7BBC829808")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06003E6C RID: 15980 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x17000738")]
		public int MaxCachedCount
		{
			[Token(Token = "0x6003E6C")]
			[Address(RVA = "0x20298E4", Offset = "0x20298E4", VA = "0x7BBC8298E4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6D")]
		[Address(RVA = "0x20298EC", Offset = "0x20298EC", VA = "0x7BBC8298EC")]
		public void InitEasyList(IEasyList eastlistCallBack, bool disableRefreshWhenInvisible = false)
		{
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x000136E0 File Offset: 0x000118E0
		[Token(Token = "0x6003E6E")]
		[Address(RVA = "0x2029CC8", Offset = "0x2029CC8", VA = "0x7BBC829CC8")]
		private bool CheckInitial()
		{
			return default(bool);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6F")]
		[Address(RVA = "0x2029DC4", Offset = "0x2029DC4", VA = "0x7BBC829DC4")]
		private void OnDragExcessBounds()
		{
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E70")]
		[Address(RVA = "0x202A270", Offset = "0x202A270", VA = "0x7BBC82A270")]
		private void PrepareQuickChildControllers()
		{
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E71")]
		[Address(RVA = "0x202A9E4", Offset = "0x202A9E4", VA = "0x7BBC82A9E4")]
		private void PrepareChildControllers(bool useCache = false)
		{
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E72")]
		[Address(RVA = "0x202B158", Offset = "0x202B158", VA = "0x7BBC82B158")]
		private void onWrapInitializeItem(GameObject go, int wrapIndex, int realIndex)
		{
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E73")]
		[Address(RVA = "0x202B370", Offset = "0x202B370", VA = "0x7BBC82B370")]
		private UIEasyListItemController GetItemControllerFromCache(GameObject go, int wrapIndex)
		{
			return null;
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x000136F8 File Offset: 0x000118F8
		[Token(Token = "0x6003E74")]
		[Address(RVA = "0x202B5DC", Offset = "0x202B5DC", VA = "0x7BBC82B5DC")]
		public bool ScrollTo(int index, bool Restrictflag = true)
		{
			return default(bool);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E75")]
		[Address(RVA = "0x202B8E8", Offset = "0x202B8E8", VA = "0x7BBC82B8E8")]
		public void ForceUpdateWrapContent()
		{
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E76")]
		[Address(RVA = "0x202B918", Offset = "0x202B918", VA = "0x7BBC82B918")]
		public void ClearAllEasyListItem()
		{
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E77")]
		public void RefreshEasyListView<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true)
		{
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E78")]
		public void RefreshEasyListViewNoClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true)
		{
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E79")]
		public void RefreshEasyListViewQuickNoClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true)
		{
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E7A")]
		[Address(RVA = "0x202BA78", Offset = "0x202BA78", VA = "0x7BBC82BA78")]
		private void SetItemsCount(int count, bool resetScroll)
		{
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7B")]
		[Address(RVA = "0x202BB08", Offset = "0x202BB08", VA = "0x7BBC82BB08")]
		public object GetItemData(int index)
		{
			return null;
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7C")]
		public T GetItemController<T>(object data, bool needScroll = true, bool Restrictflag = true) where T : UIEasyListItemController
		{
			return null;
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7D")]
		[Address(RVA = "0x202BBCC", Offset = "0x202BBCC", VA = "0x7BBC82BBCC")]
		public UIEasyListItemController[] GetItemControllersInCurrentPage()
		{
			return null;
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7E")]
		[Address(RVA = "0x202BBD4", Offset = "0x202BBD4", VA = "0x7BBC82BBD4")]
		public UIEasyListItemController GetFirstItemControllerInCurrentPage()
		{
			return null;
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E7F")]
		[Address(RVA = "0x202BD34", Offset = "0x202BD34", VA = "0x7BBC82BD34")]
		public UIEasyListItemController GetLastItemControllerInCurrentPage()
		{
			return null;
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E80")]
		public T GetItemController<T>(int index, bool needScroll = true, bool Restrictflag = true) where T : UIEasyListItemController
		{
			return null;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E81")]
		[Address(RVA = "0x202BE8C", Offset = "0x202BE8C", VA = "0x7BBC82BE8C")]
		public void SelectItem(int index, bool Restrictflag = true)
		{
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E82")]
		[Address(RVA = "0x202BFAC", Offset = "0x202BFAC", VA = "0x7BBC82BFAC")]
		public void UnSelectItem(int index, bool Restrictflag = true)
		{
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x00013710 File Offset: 0x00011910
		[Token(Token = "0x6003E83")]
		[Address(RVA = "0x202C080", Offset = "0x202C080", VA = "0x7BBC82C080")]
		public int GetLastIndexClick()
		{
			return 0;
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E84")]
		[Address(RVA = "0x202C088", Offset = "0x202C088", VA = "0x7BBC82C088")]
		public void SetLastClickIndex(int click)
		{
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x202C090", Offset = "0x202C090", VA = "0x7BBC82C090")]
		public Transform GetItemTransform(int index, bool needScroll = true)
		{
			return null;
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x202C244", Offset = "0x202C244", VA = "0x7BBC82C244")]
		public void RefreshView()
		{
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x202C278", Offset = "0x202C278", VA = "0x7BBC82C278")]
		private void ItemSelectCallBack(int index)
		{
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x202C3E8", Offset = "0x202C3E8", VA = "0x7BBC82C3E8")]
		private void ItemClickCallBack(int index)
		{
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x202C574", Offset = "0x202C574", VA = "0x7BBC82C574")]
		public UIEasyList()
		{
		}

		// Token: 0x04004EBA RID: 20154
		[Token(Token = "0x4004EBA")]
		[FieldOffset(Offset = "0x18")]
		public UIScrollView m_ListScrollView;

		// Token: 0x04004EBB RID: 20155
		[Token(Token = "0x4004EBB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_ListContainer;

		// Token: 0x04004EBC RID: 20156
		[Token(Token = "0x4004EBC")]
		[FieldOffset(Offset = "0x28")]
		public float m_ItemWidth;

		// Token: 0x04004EBD RID: 20157
		[Token(Token = "0x4004EBD")]
		[FieldOffset(Offset = "0x2C")]
		public float m_ItemHeight;

		// Token: 0x04004EBE RID: 20158
		[Token(Token = "0x4004EBE")]
		[FieldOffset(Offset = "0x30")]
		public int m_Columns;

		// Token: 0x04004EBF RID: 20159
		[Token(Token = "0x4004EBF")]
		[FieldOffset(Offset = "0x34")]
		private bool m_DisableRefreshWhenInvisible;

		// Token: 0x04004EC0 RID: 20160
		[Token(Token = "0x4004EC0")]
		[FieldOffset(Offset = "0x38")]
		private IEasyList m_EasyListCallBack;

		// Token: 0x04004EC1 RID: 20161
		[Token(Token = "0x4004EC1")]
		[FieldOffset(Offset = "0x40")]
		private UIWrapContentExtend m_WrapContent;

		// Token: 0x04004EC2 RID: 20162
		[Token(Token = "0x4004EC2")]
		[FieldOffset(Offset = "0x48")]
		private List<object> m_DataList;

		// Token: 0x04004EC3 RID: 20163
		[Token(Token = "0x4004EC3")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 m_PanelSize;

		// Token: 0x04004EC4 RID: 20164
		[Token(Token = "0x4004EC4")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_ItemSize;

		// Token: 0x04004EC5 RID: 20165
		[Token(Token = "0x4004EC5")]
		[FieldOffset(Offset = "0x60")]
		private UIPanel m_ScrollViewPanel;

		// Token: 0x04004EC6 RID: 20166
		[Token(Token = "0x4004EC6")]
		[FieldOffset(Offset = "0x68")]
		private int m_RealIndexInList;

		// Token: 0x04004EC7 RID: 20167
		[Token(Token = "0x4004EC7")]
		[FieldOffset(Offset = "0x6C")]
		private int m_LastIndexClicked;

		// Token: 0x04004EC8 RID: 20168
		[Token(Token = "0x4004EC8")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<object, int> m_DataWrapIndexDict;

		// Token: 0x04004EC9 RID: 20169
		[Token(Token = "0x4004EC9")]
		[FieldOffset(Offset = "0x78")]
		public UIEasyList.OnDataListShowFinished onDataListShowFinished;

		// Token: 0x04004ECA RID: 20170
		[Token(Token = "0x4004ECA")]
		[FieldOffset(Offset = "0x80")]
		private UIEasyListItemController[] m_CreatedItemCache;

		// Token: 0x04004ECB RID: 20171
		[Token(Token = "0x4004ECB")]
		[FieldOffset(Offset = "0x88")]
		private bool m_IsInited;

		// Token: 0x04004ECC RID: 20172
		[Token(Token = "0x4004ECC")]
		[FieldOffset(Offset = "0x8C")]
		private int m_LineCountPerPage;

		// Token: 0x02001023 RID: 4131
		// (Invoke) Token: 0x06003E8B RID: 16011
		[Token(Token = "0x2001023")]
		public delegate void OnDataListShowFinished();
	}
}
